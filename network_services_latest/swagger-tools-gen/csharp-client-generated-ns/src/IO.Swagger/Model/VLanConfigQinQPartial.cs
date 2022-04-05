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
    /// A QinQ vlan configuration
    /// </summary>
    [DataContract]
        public partial class VLanConfigQinQPartial :  IEquatable<VLanConfigQinQPartial>, IValidatableObject
    {
        /// <summary>
        /// The ethertype of the outer tag in hexadecimal notation.
        /// </summary>
        /// <value>The ethertype of the outer tag in hexadecimal notation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OuterVlanEthertypeEnum
        {
            /// <summary>
            /// Enum _0x8100 for value: 0x8100
            /// </summary>
            [EnumMember(Value = "0x8100")]
            _0x8100 = 1,
            /// <summary>
            /// Enum _0x88a8 for value: 0x88a8
            /// </summary>
            [EnumMember(Value = "0x88a8")]
            _0x88a8 = 2,
            /// <summary>
            /// Enum _0x9100 for value: 0x9100
            /// </summary>
            [EnumMember(Value = "0x9100")]
            _0x9100 = 3        }
        /// <summary>
        /// The ethertype of the outer tag in hexadecimal notation.
        /// </summary>
        /// <value>The ethertype of the outer tag in hexadecimal notation.</value>
        [DataMember(Name="outer_vlan_ethertype", EmitDefaultValue=false)]
        public OuterVlanEthertypeEnum? OuterVlanEthertype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VLanConfigQinQPartial" /> class.
        /// </summary>
        /// <param name="innerVlan">The inner VLAN id. .</param>
        /// <param name="outerVlan">The outer VLAN id. If &#x60;null&#x60;, the IXP will auto-select a valid vlan-id. .</param>
        /// <param name="outerVlanEthertype">The ethertype of the outer tag in hexadecimal notation. (default to OuterVlanEthertypeEnum._0x8100).</param>
        /// <param name="vlanType">vlanType (required).</param>
        public VLanConfigQinQPartial(int? innerVlan = default(int?), int? outerVlan = default(int?), OuterVlanEthertypeEnum? outerVlanEthertype = OuterVlanEthertypeEnum._0x8100, string vlanType = default(string))
        {
            // to ensure "vlanType" is required (not null)
            if (vlanType == null)
            {
                throw new InvalidDataException("vlanType is a required property for VLanConfigQinQPartial and cannot be null");
            }
            else
            {
                this.VlanType = vlanType;
            }
            this.InnerVlan = innerVlan;
            this.OuterVlan = outerVlan;
            // use default value if no "outerVlanEthertype" provided
            if (outerVlanEthertype == null)
            {
                this.OuterVlanEthertype = OuterVlanEthertypeEnum._0x8100;
            }
            else
            {
                this.OuterVlanEthertype = outerVlanEthertype;
            }
        }
        
        /// <summary>
        /// The inner VLAN id. 
        /// </summary>
        /// <value>The inner VLAN id. </value>
        [DataMember(Name="inner_vlan", EmitDefaultValue=false)]
        public int? InnerVlan { get; set; }

        /// <summary>
        /// The outer VLAN id. If &#x60;null&#x60;, the IXP will auto-select a valid vlan-id. 
        /// </summary>
        /// <value>The outer VLAN id. If &#x60;null&#x60;, the IXP will auto-select a valid vlan-id. </value>
        [DataMember(Name="outer_vlan", EmitDefaultValue=false)]
        public int? OuterVlan { get; set; }


        /// <summary>
        /// Gets or Sets VlanType
        /// </summary>
        [DataMember(Name="vlan_type", EmitDefaultValue=false)]
        public string VlanType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VLanConfigQinQPartial {\n");
            sb.Append("  InnerVlan: ").Append(InnerVlan).Append("\n");
            sb.Append("  OuterVlan: ").Append(OuterVlan).Append("\n");
            sb.Append("  OuterVlanEthertype: ").Append(OuterVlanEthertype).Append("\n");
            sb.Append("  VlanType: ").Append(VlanType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as VLanConfigQinQPartial);
        }

        /// <summary>
        /// Returns true if VLanConfigQinQPartial instances are equal
        /// </summary>
        /// <param name="input">Instance of VLanConfigQinQPartial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VLanConfigQinQPartial input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InnerVlan == input.InnerVlan ||
                    (this.InnerVlan != null &&
                    this.InnerVlan.Equals(input.InnerVlan))
                ) && 
                (
                    this.OuterVlan == input.OuterVlan ||
                    (this.OuterVlan != null &&
                    this.OuterVlan.Equals(input.OuterVlan))
                ) && 
                (
                    this.OuterVlanEthertype == input.OuterVlanEthertype ||
                    (this.OuterVlanEthertype != null &&
                    this.OuterVlanEthertype.Equals(input.OuterVlanEthertype))
                ) && 
                (
                    this.VlanType == input.VlanType ||
                    (this.VlanType != null &&
                    this.VlanType.Equals(input.VlanType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.InnerVlan != null)
                    hashCode = hashCode * 59 + this.InnerVlan.GetHashCode();
                if (this.OuterVlan != null)
                    hashCode = hashCode * 59 + this.OuterVlan.GetHashCode();
                if (this.OuterVlanEthertype != null)
                    hashCode = hashCode * 59 + this.OuterVlanEthertype.GetHashCode();
                if (this.VlanType != null)
                    hashCode = hashCode * 59 + this.VlanType.GetHashCode();
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
