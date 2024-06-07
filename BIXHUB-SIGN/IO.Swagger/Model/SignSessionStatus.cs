/* 
 * Sign
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.Model
{
    /// <summary>
    /// Defines SignSessionStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum SignSessionStatus
    {
        /// <summary>
        /// Enum Initializing for value: Initializing
        /// </summary>
        [EnumMember(Value = "Initializing")]
        Initializing = 1,
        /// <summary>
        /// Enum Created for value: Created
        /// </summary>
        [EnumMember(Value = "Created")]
        Created = 2,
        /// <summary>
        /// Enum Deleted for value: Deleted
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted = 3,
        /// <summary>
        /// Enum Approved for value: Approved
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved = 4,
        /// <summary>
        /// Enum RejectedByApprover for value: RejectedByApprover
        /// </summary>
        [EnumMember(Value = "RejectedByApprover")]
        RejectedByApprover = 5,
        /// <summary>
        /// Enum InProgress for value: InProgress
        /// </summary>
        [EnumMember(Value = "InProgress")]
        InProgress = 6,
        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 7,
        /// <summary>
        /// Enum DeletedByRetention for value: DeletedByRetention
        /// </summary>
        [EnumMember(Value = "DeletedByRetention")]
        DeletedByRetention = 8,
        /// <summary>
        /// Enum FailedTooManyAttempts for value: FailedTooManyAttempts
        /// </summary>
        [EnumMember(Value = "FailedTooManyAttempts")]
        FailedTooManyAttempts = 9,
        /// <summary>
        /// Enum RejectedBySigner for value: RejectedBySigner
        /// </summary>
        [EnumMember(Value = "RejectedBySigner")]
        RejectedBySigner = 10    }
}
