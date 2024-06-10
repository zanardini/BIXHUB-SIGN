using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace BixHubWrapper.Model
{
    public class InfoSessionResponse
    {
        public Guid SessionGuid { get; set; }
        public string ExternalID { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string FlowType { get; set; }
        public string IdentificationStatus { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Workflow { get; set; }
        public string Process { get; set; }
        public string Reason { get; set; }
        public string NextActors { get; set; }
        public string Errors { get; set; }
        public string NextUri { get; set; }

        public override string ToString()
        {
            var result = string.Empty;
            result += string.Format("  SessionGuid: {0}", SessionGuid);
            result += Environment.NewLine + string.Format("  Description: {0}", Description);
            result += Environment.NewLine + string.Format("  ExternalID: {0}", ExternalID);
            result += Environment.NewLine + string.Format("  CreatedDate: {0}", CreatedDate);
            result += Environment.NewLine + string.Format("  UpdatedDate: {0}", UpdatedDate);
            result += Environment.NewLine + string.Format("  CompletedDate: {0}", CompletedDate);
            result += Environment.NewLine + string.Format("  FlowType: {0}", FlowType);
            result += Environment.NewLine + string.Format("  IdentificationStatus: {0}", IdentificationStatus);
            result += Environment.NewLine + string.Format("  Status: {0}", Status);
            result += Environment.NewLine + string.Format("  Workflow: {0}", Workflow);
            result += Environment.NewLine + string.Format("  Process: {0}", Process);
            result += Environment.NewLine + string.Format("  Reason: {0}", Reason);
            result += Environment.NewLine + string.Format("  NextActors: {0}", NextActors);
            result += Environment.NewLine + string.Format("  Errors: {0}", Errors);
            result += Environment.NewLine + string.Format("  NextUri: {0}", NextUri);
            return result;
        }
    }
}