/* 
 * IX-API
 *
 *  This API allows to config/change/delete Internet Exchange services.  # Filters  When querying collections, the provided query parameters are validated. Unknown query parameters are ignored. Providing invalid filter values should yield a validation error. 
 *
 * OpenAPI spec version: 2.2.0
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
    /// MP2MPNetworkService
    /// </summary>
    [DataContract]
        public partial class MP2MPNetworkService : MP2MPNetworkServicePartial,  IEquatable<MP2MPNetworkService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MP2MPNetworkService" /> class.
        /// </summary>
        public MP2MPNetworkService(string billingAccount = default(string), DateTime? chargedUntil = default(DateTime?), string consumingAccount = default(string), string contractRef = default(string), DateTime? decommissionAt = default(DateTime?), string externalRef = default(string), string id = default(string), string managingAccount = default(string), List<string> memberJoiningRules = default(List<string>), string name = default(string), List<string> networkFeatures = default(List<string>), string productOffering = default(string), bool? _public = false, string purchaseOrder = "", StateEnum state = default(StateEnum), List<Status> status = default(List<Status>), string type = default(string)) : base(billingAccount, chargedUntil, consumingAccount, contractRef, decommissionAt, externalRef, id, managingAccount, memberJoiningRules, name, networkFeatures, nscRequiredContactRoles, productOffering, _public, purchaseOrder, state, status, type)
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MP2MPNetworkService {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MP2MPNetworkService);
        }

        /// <summary>
        /// Returns true if MP2MPNetworkService instances are equal
        /// </summary>
        /// <param name="input">Instance of MP2MPNetworkService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MP2MPNetworkService input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
