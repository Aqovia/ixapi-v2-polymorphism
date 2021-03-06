/* 
 * IX-API
 *
 *  This API allows to config/change/delete Internet Exchange services.  # Filters  When querying collections, the provided query parameters are validated. Unknown query parameters are ignored. Providing invalid filter values should yield a validation error. 
 *
 * The version of the OpenAPI document: 2.2.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// VLanConfigQinQ
    /// </summary>
    [DataContract]
    public partial class VLanConfigQinQ : VLanConfigQinQPartial,  IEquatable<VLanConfigQinQ>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VLanConfigQinQ" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VLanConfigQinQ() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VLanConfigQinQ" /> class.
        /// </summary>
        /// <param name="innerVlan">The inner VLAN id. .</param>
        /// <param name="outerVlan">The outer VLAN id. If &#x60;null&#x60;, the IXP will auto-select a valid vlan-id. .</param>
        /// <param name="outerVlanEthertype">The ethertype of the outer tag in hexadecimal notation. (default to OuterVlanEthertypeEnum._0x8100).</param>
        /// <param name="vlanType">vlanType (required).</param>
        public VLanConfigQinQ(int innerVlan = default(int), int? outerVlan = default(int?), OuterVlanEthertypeEnum? outerVlanEthertype = OuterVlanEthertypeEnum._0x8100, string vlanType = default(string)) : base(innerVlan, outerVlan, outerVlanEthertype, vlanType)
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VLanConfigQinQ {\n");
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
            return this.Equals(input as VLanConfigQinQ);
        }

        /// <summary>
        /// Returns true if VLanConfigQinQ instances are equal
        /// </summary>
        /// <param name="input">Instance of VLanConfigQinQ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VLanConfigQinQ input)
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
