/* 
 * OnBoarding
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
namespace IO.Swagger.IdeModel
{
    /// <summary>
    /// Defines SessionStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionStatus
    {
        /// <summary>
        /// Enum Pending for value: Pending
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending = 1,
        /// <summary>
        /// Enum InProgress for value: InProgress
        /// </summary>
        [EnumMember(Value = "InProgress")]
        InProgress = 2,
        /// <summary>
        /// Enum InVerify for value: InVerify
        /// </summary>
        [EnumMember(Value = "InVerify")]
        InVerify = 3,
        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 4,
        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 5,
        /// <summary>
        /// Enum Deleted for value: Deleted
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted = 6,
        /// <summary>
        /// Enum DeletedByRetention for value: DeletedByRetention
        /// </summary>
        [EnumMember(Value = "DeletedByRetention")]
        DeletedByRetention = 7,
        /// <summary>
        /// Enum FailedTooManyAttempts for value: FailedTooManyAttempts
        /// </summary>
        [EnumMember(Value = "FailedTooManyAttempts")]
        FailedTooManyAttempts = 8,
        /// <summary>
        /// Enum FailedSpidCie for value: FailedSpidCie
        /// </summary>
        [EnumMember(Value = "FailedSpidCie")]
        FailedSpidCie = 9    }
}
