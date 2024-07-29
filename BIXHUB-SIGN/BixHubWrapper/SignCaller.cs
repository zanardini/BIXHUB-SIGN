using IO.Swagger.Model;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace BixHubWrapper
{
    public class SignCaller
    {
        private readonly string _authUrl;
        private readonly string _signUrl;
        public string AccessToken { get { return _accessToken; } }
        private string _accessToken;

        public SignCaller(string authUrl, string signUrl)
        {
            _authUrl = authUrl;
            _signUrl = signUrl;
        }

        public IO.Swagger.Client.Configuration Configuration
        {
            get
            {
                {
                    return new IO.Swagger.Client.Configuration()
                    {
                        AccessToken = _accessToken,
                        BasePath = _signUrl + "/SignService",
                        ApiKey = new Dictionary<string, string>() { { "Authorization", _accessToken } },
                        ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "Bearer" } }
                    };
                }
            }
        }

        public async void Login(string clientGuid, string clientId, string clientSecret)
        {
            HttpClient client = new HttpClient();
            var request = new
            {
                client_Id = clientId,
                client_secret = clientSecret,
                grant_Type = "client_credentials"
            };
            StringContent content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var task = Task.Run(() => client.PostAsync($"{_authUrl}/AuthorizationService/api/{clientGuid}/oauth/Token", content));
            task.Wait();
            var response = task.Result;

            //var response = await client.PostAsync($"{_url}/AuthorizationService/api/{clientGuid}/oauth/Token", content);
            string json = await response.Content.ReadAsStringAsync();
            var accessTokenDto = JsonConvert.DeserializeObject<BixHubWrapper.Model.TokenFromUserResult>(json);
            _accessToken = accessTokenDto.access_token;
        }

        public Guid CreateNewSignSessionFEA(string email, string description, string taxCode, string phoneNumber, string returnUrl, string externalID, bool addApprover)
        {
            var sessionDescription = "Firma avanzata del contratto";
            var fileToSign = @"C:\Temp\BixHub\FEA_ContrattoAgenzia.pdf";
            var acceptToSign = @"C:\Temp\BixHub\FEA_Adesione.pdf";

            IO.Swagger.Api.SessionLifeCycleApi sessionLifeCycleApi = new IO.Swagger.Api.SessionLifeCycleApi(Configuration);
            SavedFileResponse acceptUploaded = sessionLifeCycleApi.ApiV1SessionLifeCycleUploadFileBase64Post(new UploadFileBase64Request(System.Convert.ToBase64String(System.IO.File.ReadAllBytes(acceptToSign)), System.IO.Path.GetFileName(acceptToSign), MimeMapping.GetMimeMapping(acceptToSign)));
            SavedFileResponse documentUploaded = sessionLifeCycleApi.ApiV1SessionLifeCycleUploadFileBase64Post(new UploadFileBase64Request(System.Convert.ToBase64String(System.IO.File.ReadAllBytes(fileToSign)), System.IO.Path.GetFileName(fileToSign), MimeMapping.GetMimeMapping(fileToSign)));

            var attributes = new Dictionary<string, string>
            {
            };

            // parameters sono i parametri di funzionamento del servizio quali la lingua utente nonchè la URL di redirect a fine sessione
            var parameters = new Dictionary<string, string> {
                { "returnUrl", returnUrl },
                { "language", "it" }
            };
            // è possibile indicare metadati da salvare lato BIX-IDE per poi favorire il match
            var metadata = new Dictionary<string, string> {
                { "externalID", externalID }
            };

            List<CreateWebhookDto> webhooks = new List<CreateWebhookDto>();

            List<CreateApproverDto> approvers = new List<CreateApproverDto>();
            if (addApprover)
                approvers.Add(new CreateApproverDto(email, description, 0, returnUrl, externalID));

            List<CreateFollowerDto> followers = new List<CreateFollowerDto>();

            List<CreateSignerDto> signers = new List<CreateSignerDto>();
            List<CreateFieldGroupDto> fieldsGroup1 = new List<CreateFieldGroupDto>();
            List<CreateFieldGroupDocumentDto> fg_documents = new List<CreateFieldGroupDocumentDto>();
            List<CreateFieldDto> fg_fieldsAccept = new List<CreateFieldDto>();
            List<CreateFieldDto> fg_fieldsDocument = new List<CreateFieldDto>();

            fg_fieldsAccept.Add(new CreateFieldDto(FieldType.TextBox
             , "Valorizzare con il luogo"
             , 0, false, "" , "0", null
             , null, null, FontAbleTech.TimesRoman, null, null, null, ""
             , DatePickerConstraint.Today
             , new CreatePositionDto(PositionType.AcroField, "Luogo")));

            fg_fieldsAccept.Add(new CreateFieldDto(FieldType.DatePicker
             , "Data della firma"
             , 1, false, "", "1", null
             , null, null, FontAbleTech.TimesRoman, null, null, null, ""
             , DatePickerConstraint.Today
             , new CreatePositionDto(PositionType.AcroField, "Data")));

            fg_fieldsAccept.Add(new CreateFieldDto(FieldType.Signature
                , "Firma per accettazione delle condizioni di servizio"
                , 2, false, "", "2", null, null, null
                , FontAbleTech.TimesRoman, null, null, null, ""
                , DatePickerConstraint.Today
                , new CreatePositionDto(PositionType.AcroField, "Signature1")));

            fg_fieldsDocument.Add(new CreateFieldDto(FieldType.Signature
               , "Firma per accettazione del mandato di agenzia"
               , 3, false, "", "3", null, null, null
               , FontAbleTech.TimesRoman, null, null, null, ""
               , DatePickerConstraint.Today
               , new CreatePositionDto(PositionType.AcroField, "Signature2")));

            fg_documents.Add(new CreateFieldGroupDocumentDto(acceptUploaded.FileGuid, 0, fg_fieldsAccept));
            fg_documents.Add(new CreateFieldGroupDocumentDto(documentUploaded.FileGuid, 1, fg_fieldsDocument));
            fieldsGroup1.Add(new CreateFieldGroupDto("Primo Gruppo", 0, fg_documents));

            List<CreateAttachmentDto> attachments = new List<CreateAttachmentDto>();
            signers.Add(new IO.Swagger.Model.CreateSignerDto(description, email, phoneNumber, taxCode, VerificationModeDto.SmsOtp, 0, returnUrl, externalID, fieldsGroup1, attachments));

            List<CreateDocumentDto> documents = new List<CreateDocumentDto>();
            documents.Add(new CreateDocumentDto("Adesione al servizio FEA", acceptUploaded.FileGuid, null, "Adesione al servizio FEA", false, 0));
            documents.Add(new CreateDocumentDto("Contratto di agenzia", documentUploaded.FileGuid, null, "Contratto di agenzia", false, 1));

            IO.Swagger.Model.CreateSessionRequest body = new IO.Swagger.Model.CreateSessionRequest(SignSessionProcessTypeDto.ES, WorkFlowType.Automatic, sessionDescription, metadata, parameters, attributes, webhooks,
                approvers, followers, documents, signers, true, true, true);
            IO.Swagger.Model.CreateSessionResponse response = sessionLifeCycleApi.ApiV1SessionLifeCycleCreatePost(body);

            if (response.SessionGuid == null)
                throw new Exception("Post return null");

            IO.Swagger.Model.PublishSessionResponse a = sessionLifeCycleApi.ApiV1SessionLifeCyclePublishSessionGuidPost(response.SessionGuid.Value);
            return response.SessionGuid.Value;
        }

        public Guid CreateNewSignSessionFES(string email, string description, string taxCode, string phoneNumber, string returnUrl, string externalID, bool addApprover)
        {
            var sessionDescription = "Firma semplice del modulo privacy";
            var fileToSign = @"C:\Temp\BixHub\FES_ModuloPrivacy.pdf";

            IO.Swagger.Api.SessionLifeCycleApi sessionLifeCycleApi = new IO.Swagger.Api.SessionLifeCycleApi(Configuration);

            SavedFileResponse documentUploaded = sessionLifeCycleApi.ApiV1SessionLifeCycleUploadFileBase64Post(new UploadFileBase64Request(System.Convert.ToBase64String(System.IO.File.ReadAllBytes(fileToSign)), System.IO.Path.GetFileName(fileToSign), MimeMapping.GetMimeMapping(fileToSign)));

            var attributes = new Dictionary<string, string>
            {
            };

            // parameters sono i parametri di funzionamento del servizio quali la lingua utente nonchè la URL di redirect a fine sessione
            var parameters = new Dictionary<string, string> {
                { "returnUrl", returnUrl },
                { "language", "it" }
            };
            // è possibile indicare metadati da salvare lato BIX-IDE per poi favorire il match
            var metadata = new Dictionary<string, string> {
                { "externalID", externalID }
            };

            List<CreateWebhookDto> webhooks = new List<CreateWebhookDto>();

            List<CreateApproverDto> approvers = new List<CreateApproverDto>();
            if (addApprover)
                approvers.Add(new CreateApproverDto(email, description, 0, returnUrl, externalID));

            List<CreateFollowerDto> followers = new List<CreateFollowerDto>();

            List<CreateSignerDto> signers = new List<CreateSignerDto>();
            List<CreateFieldGroupDto> fieldsGroup1 = new List<CreateFieldGroupDto>();
            List<CreateFieldGroupDocumentDto> fg_documents = new List<CreateFieldGroupDocumentDto>();
            List<CreateFieldDto> fg_fields = new List<CreateFieldDto>();

            fg_fields.Add(new CreateFieldDto(FieldType.RadioGroup
                , "Consenso finalità di adempimento contrattuale delle prestazioni da me richieste"
                , 0, false, "", "0", null
                , new List<CreateRadioButtonFieldDto>
                {
                    new CreateRadioButtonFieldDto("Do il consenso", 0)
                    , new CreateRadioButtonFieldDto("Nego il consenso", 1)
                }
                , null, FontAbleTech.TimesRoman, null, null, null, ""
                , DatePickerConstraint.Today
                , new CreatePositionDto(PositionType.AcroField, "Group1")));

            fg_fields.Add(new CreateFieldDto(FieldType.RadioGroup
                , "Consenso finalità di analisi e ricerche di mercato per migliorare l'offerta di prodotti"
                , 1, false,"", "1", null
                , new List<CreateRadioButtonFieldDto>
                {
                                new CreateRadioButtonFieldDto("Do il consenso", 0)
                                , new CreateRadioButtonFieldDto("Nego il consenso", 1)
                }
                , null, FontAbleTech.TimesRoman, null, null, null, ""
                , DatePickerConstraint.Today
                , new CreatePositionDto(PositionType.AcroField, "Group2")));

            fg_fields.Add(new CreateFieldDto(FieldType.RadioGroup
                , "Consenso finalità commerciali e di marketing diretto e indiretto come indicato nell'informativa"
                , 2, false, "", "2", null
                , new List<CreateRadioButtonFieldDto>
                {
                                new CreateRadioButtonFieldDto("Do il consenso", 0)
                                , new CreateRadioButtonFieldDto("Nego il consenso", 1)
                }
                , null, FontAbleTech.TimesRoman, null, null, null, ""
                , DatePickerConstraint.Today
                , new CreatePositionDto(PositionType.AcroField, "Group3")));

            fg_fields.Add(new CreateFieldDto(FieldType.RadioGroup
                , "Consenso al trasferimento dei miei suddetti dati verso i paesi indicati nell'informativa"
                , 3, false, "" , "3", null
                , new List<CreateRadioButtonFieldDto>
                {
                                new CreateRadioButtonFieldDto("Do il consenso", 0)
                                , new CreateRadioButtonFieldDto("Nego il consenso", 1)
                }
                , null, FontAbleTech.TimesRoman, null, null, null, ""
                , DatePickerConstraint.Today
                , new CreatePositionDto(PositionType.AcroField, "Group4")));

            fg_fields.Add(new CreateFieldDto(FieldType.Signature
                , "Firma per accettazione"
                , 5, false,"", "5", null, null, null, FontAbleTech.TimesRoman, null, null, null, "", DatePickerConstraint.Today
                , new CreatePositionDto(PositionType.AcroField, "Signature1")));

            fg_documents.Add(new CreateFieldGroupDocumentDto(documentUploaded.FileGuid, 0, fg_fields));
            fieldsGroup1.Add(new CreateFieldGroupDto("Primo Gruppo", 0, fg_documents));

            List<CreateAttachmentDto> attachments = new List<CreateAttachmentDto>();
            signers.Add(new IO.Swagger.Model.CreateSignerDto(description, email, phoneNumber, taxCode, VerificationModeDto.SmsOtp, 0, returnUrl, externalID, fieldsGroup1, attachments));

            List<CreateDocumentDto> documents = new List<CreateDocumentDto>();
            documents.Add(new CreateDocumentDto("Informativa Privacy", documentUploaded.FileGuid, null, "Informativa Privacy", false));

            IO.Swagger.Model.CreateSessionRequest body = new IO.Swagger.Model.CreateSessionRequest(SignSessionProcessTypeDto.ES, WorkFlowType.Automatic, sessionDescription, metadata, parameters, attributes, webhooks,
                approvers, followers, documents, signers, false, true, true);
            IO.Swagger.Model.CreateSessionResponse response = sessionLifeCycleApi.ApiV1SessionLifeCycleCreatePost(body);

            if (response.SessionGuid == null)
                throw new Exception("Post return null");

            IO.Swagger.Model.PublishSessionResponse a = sessionLifeCycleApi.ApiV1SessionLifeCyclePublishSessionGuidPost(response.SessionGuid.Value);
            return response.SessionGuid.Value;
        }

        public void DeleteIdentificationSession(Guid sessionGuid)
        {
            IO.Swagger.Api.SessionLifeCycleApi sessionLifeCycleApi = new IO.Swagger.Api.SessionLifeCycleApi(Configuration);
            sessionLifeCycleApi.ApiV1SessionLifeCycleDeleteSessionGuidDelete(sessionGuid);
        }

        public BixHubWrapper.Model.InfoSessionResponse GetSession(Guid sessionGuid)
        {
            IO.Swagger.Api.SessionLifeCycleApi sessionLifeCycleApi = new IO.Swagger.Api.SessionLifeCycleApi(Configuration);
            IO.Swagger.Model.GetSessionDetailResponse sessionModel = sessionLifeCycleApi.ApiV1SessionLifeCycleGetSessionGuidGet(sessionGuid);
            List<IO.Swagger.Model.GetStatusSessionResponse> statusModelList = sessionLifeCycleApi.ApiV1SessionLifeCycleGetStatusPost(new List<Guid?> { sessionGuid });
            IO.Swagger.Model.GetStatusSessionResponse statusModel = statusModelList.FirstOrDefault();
            var result = InfoSessionResponseTranslate(sessionGuid, sessionModel, statusModel);
            return result;

        }

        public List<BixHubWrapper.Model.InfoSessionResponse> GetSessionList()
        {
            IO.Swagger.Api.SessionLifeCycleApi sessionLifeCycleApi = new IO.Swagger.Api.SessionLifeCycleApi(Configuration);
            IO.Swagger.Model.GetAllSessionRequest request = new IO.Swagger.Model.GetAllSessionRequest(null, null);
            var sessionResponse = sessionLifeCycleApi.ApiV1SessionLifeCycleGetAllPost(request);
            var result = new List<BixHubWrapper.Model.InfoSessionResponse>();
            if (sessionResponse == null)
                return result;
            if (sessionResponse._List == null)
                return result;
            foreach (IO.Swagger.Model.GetAllSessionResponse session in sessionResponse._List)
                if (session.SessionGuid != null)
                    result.Add(GetSession(session.SessionGuid.Value));
            return result;
        }

        private BixHubWrapper.Model.InfoSessionResponse InfoSessionResponseTranslate(Guid? sessionGuid, IO.Swagger.Model.GetSessionDetailResponse sessionModel, IO.Swagger.Model.GetStatusSessionResponse statusModel)
        {
            if (sessionModel == null)
                return null;

            BixHubWrapper.Model.InfoSessionResponse result = new BixHubWrapper.Model.InfoSessionResponse();
            if (sessionGuid != null)
                result.SessionGuid = sessionGuid.Value;
            if (sessionModel.CreatedDate != null)
                result.CreatedDate = sessionModel.CreatedDate.Value.ToLocalTime();
            if (sessionModel.Metadata != null)
            {
                var f = sessionModel.Metadata.FirstOrDefault(x => x.Key == "externalID");
                if (f.Key != null)
                    result.ExternalID = f.Value;
            }
            if (statusModel != null)
            {
                result.Description = sessionModel.Description;
                result.Status = statusModel.Status.ToString();
                result.CompletedDate = statusModel.CompletedDate == null ? DateTime.MinValue : statusModel.CompletedDate.Value.ToLocalTime();
                result.Workflow = sessionModel.WorkFlow.ToString();
                result.Process = sessionModel.Process.ToString();
                result.NextUri = "";
                if (statusModel.NextActors != null && statusModel.NextActors.Count > 0)
                    result.NextUri = statusModel.NextActors[0].Uri;
            }
            return result;
        }

        public byte[] GetAuditTrailSignBySessionGuid(Guid sessionGuid)
        {
            IO.Swagger.Api.SessionLifeCycleApi sessionLifeCycleApi = new IO.Swagger.Api.SessionLifeCycleApi(Configuration);
            var response = sessionLifeCycleApi.ApiV1SessionLifeCycleGetAuditTrailSessionGuidGet(sessionGuid);
            return response;
        }

        
        public Dictionary<string, byte[]> GetSignedFiles(Guid sessionGuid)
        {
            var result = new Dictionary<string, byte[]>();

            IO.Swagger.Api.SessionLifeCycleApi sessionLifeCycleApi = new IO.Swagger.Api.SessionLifeCycleApi(Configuration);
            IO.Swagger.Model.GetSessionDetailResponse sessionModel = sessionLifeCycleApi.ApiV1SessionLifeCycleGetSessionGuidGet(sessionGuid);
            List<IO.Swagger.Model.GetStatusSessionResponse> statusModelList = sessionLifeCycleApi.ApiV1SessionLifeCycleGetStatusPost(new List<Guid?> { sessionGuid });
            IO.Swagger.Model.GetStatusSessionResponse statusModel = statusModelList.FirstOrDefault();

            foreach (var document in sessionModel.Documents)
            {
                var doc = sessionLifeCycleApi.ApiV1SessionLifeCycleGetSignedResultSessionGuidDocumentGuidGet(sessionGuid, document.Guid);
                result.Add(document.ExternalId, doc);
            }
            return result;
        }

        public Dictionary<Guid, string> GetSignersAndIdeSession(Guid sessionGuid)
        {
            var result = new Dictionary<Guid, string>();

            IO.Swagger.Api.SessionLifeCycleApi sessionLifeCycleApi = new IO.Swagger.Api.SessionLifeCycleApi(Configuration);
            IO.Swagger.Model.GetSessionDetailResponse sessionModel = sessionLifeCycleApi.ApiV1SessionLifeCycleGetSessionGuidGet(sessionGuid);
            List<IO.Swagger.Model.GetStatusSessionResponse> statusModelList = sessionLifeCycleApi.ApiV1SessionLifeCycleGetStatusPost(new List<Guid?> { sessionGuid });
            IO.Swagger.Model.GetStatusSessionResponse statusModel = statusModelList.FirstOrDefault();
            foreach (var signer in statusModel.Signers)
            {
                if (signer.IdentificationSession != null && signer.IdentificationSession.Guid != null)
                    result.Add(signer.IdentificationSession.Guid.Value, signer.TaxCode);
            }
            return result;
        }
    }
}