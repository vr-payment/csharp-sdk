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
    /// Defines BankAccountEnvironment
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BankAccountEnvironment
    {
        
        /// <summary>
        /// Enum PRODUCTION for value: PRODUCTION
        /// </summary>
        [EnumMember(Value = "PRODUCTION")]
        PRODUCTION,
        
        /// <summary>
        /// Enum TEST for value: TEST
        /// </summary>
        [EnumMember(Value = "TEST")]
        TEST
    }

}
