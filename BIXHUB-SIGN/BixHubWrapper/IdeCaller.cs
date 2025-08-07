using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BixHubWrapper
{
    public class IdeCaller
    {
        private readonly string _authUrl;
        private readonly string _ideUrl;
        public string AccessToken { get { return _accessToken; } }
        private string _accessToken;

        public IdeCaller(string authUrl, string ideUrl, string accessToken)
        {
            _authUrl = authUrl;
            _ideUrl = ideUrl;
            _accessToken = accessToken;
        }

        public Abletech.Bix.IdeService.Contract.Client.Configuration Configuration
        {
            get
            {
                {
                    return new Abletech.Bix.IdeService.Contract.Client.Configuration()
                    {
                        AccessToken = _accessToken,
                        BasePath = _ideUrl + "/OnBoardingService",
                        ApiKey = new Dictionary<string, string>() { { "Authorization", _accessToken } },
                        ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "Bearer" } }
                    };
                }
            }
        }

        public BixHubWrapper.Model.AcquiredIDInfoResponse GetIdentificationEvidenceBySessionGuid(Guid sessionGuid)
        {
            Abletech.Bix.IdeService.Contract.Client.V1.SessionLifeCycleApi sessionLifeCycleApi = new Abletech.Bix.IdeService.Contract.Client.V1.SessionLifeCycleApi(Configuration);
            var allEvidenceResponse = sessionLifeCycleApi.ApiV1SessionLifeCycleGetAcquiredIDInfoSessionGuidPost(sessionGuid, new Abletech.Bix.IdeService.Contract.Model.V1.GetAcquiredIDInfoRequest()
            {
                WithDigitalIdentityReqResp = true,
                WithIDCard = true,
                WithLivenessDetection = true,
                WithPersonalData = true,
                WithSelfie = true
            });

            BixHubWrapper.Model.AcquiredIDInfoResponse responseWrapper = JsonConvert.DeserializeObject<BixHubWrapper.Model.AcquiredIDInfoResponse>(JsonConvert.SerializeObject(allEvidenceResponse));

            return responseWrapper;

        }

        public byte[] GetAuditLogBySessionGuid(Guid sessionGuid)
        {
            Abletech.Bix.IdeService.Contract.Client.V1.SessionLifeCycleApi sessionLifeCycleApi = new Abletech.Bix.IdeService.Contract.Client.V1.SessionLifeCycleApi(Configuration);
            var response = sessionLifeCycleApi.ApiV1SessionLifeCycleGetAuditLogSessionGuidGet(sessionGuid);
            using (MemoryStream ms = new MemoryStream())
            {
                response.CopyTo(ms);
                return ms.ToArray();
            }
        }

    }
}