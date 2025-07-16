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
using SwaggerDateConverter = VRPayment.Client.SwaggerDateConverter;

namespace VRPayment.Model
{
    /// <summary>
    /// The target state indicates the state that should be set on the charge attempt.
    /// </summary>
    /// <value>The target state indicates the state that should be set on the charge attempt.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PaymentAppChargeAttemptTargetState
    {
        
        /// <summary>
        /// Enum SUCCESSFUL for value: SUCCESSFUL
        /// </summary>
        [EnumMember(Value = "SUCCESSFUL")]
        SUCCESSFUL,
        
        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED
    }

}
