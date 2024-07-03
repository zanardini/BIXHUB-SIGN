using IO.Swagger.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        public IO.Swagger.Client.Configuration Configuration
        {
            get
            {
                {
                    return new IO.Swagger.Client.Configuration()
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
            IO.Swagger.IdeApi.SessionLifeCycleApi sessionLifeCycleApi = new IO.Swagger.IdeApi.SessionLifeCycleApi(Configuration);
            var allEvidenceResponse = sessionLifeCycleApi.ApiV1SessionLifeCycleGetAcquiredIDInfoSessionGuidPost(sessionGuid, new IO.Swagger.IdeModel.GetAcquiredIDInfoRequest()
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
            IO.Swagger.IdeApi.SessionLifeCycleApi sessionLifeCycleApi = new IO.Swagger.IdeApi.SessionLifeCycleApi(Configuration);
            var response = sessionLifeCycleApi.ApiV1SessionLifeCycleGetAuditLogSessionGuidGet(sessionGuid);
            return response;
        }

    }
}