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
    /// Encodes a problem into an appropriate response body.
    /// </summary>
    [DataContract]
    public partial class ProblemResponsePartial :  IEquatable<ProblemResponsePartial>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemResponsePartial" /> class.
        /// </summary>
        /// <param name="detail">A human-readable explanation specific to this occurrence of the problem..</param>
        /// <param name="instance">A URI reference that identifies the specific occurrence of the problem.  It may or may not yield further information if dereferenced..</param>
        /// <param name="status">The HTTP status code ([RFC7231], Section 6) generated by the origin server for this occurrence of the problem..</param>
        /// <param name="title">A short, human-readable summary of the problem type.  It SHOULD NOT change from occurrence to occurrence of the problem, except for purposes of localization (e.g., using proactive content negotiation; see [RFC7231], Section 3.4). .</param>
        /// <param name="type">A URI reference (see RFC3986) that identifies the problem type.  This specification encourages that, when dereferenced, it provide human-readable documentation for the problem type (e.g., using HTML [W3C.REC-html5-20141028]).  When this member is not present, its value is assumed to be \&quot;about:blank\&quot;. .</param>
        public ProblemResponsePartial(string detail = default(string), string instance = default(string), int status = default(int), string title = default(string), string type = default(string))
        {
            this.Detail = detail;
            this.Instance = instance;
            this.Status = status;
            this.Title = title;
            this.Type = type;
        }
        
        /// <summary>
        /// A human-readable explanation specific to this occurrence of the problem.
        /// </summary>
        /// <value>A human-readable explanation specific to this occurrence of the problem.</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; set; }

        /// <summary>
        /// A URI reference that identifies the specific occurrence of the problem.  It may or may not yield further information if dereferenced.
        /// </summary>
        /// <value>A URI reference that identifies the specific occurrence of the problem.  It may or may not yield further information if dereferenced.</value>
        [DataMember(Name="instance", EmitDefaultValue=false)]
        public string Instance { get; set; }

        /// <summary>
        /// The HTTP status code ([RFC7231], Section 6) generated by the origin server for this occurrence of the problem.
        /// </summary>
        /// <value>The HTTP status code ([RFC7231], Section 6) generated by the origin server for this occurrence of the problem.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int Status { get; set; }

        /// <summary>
        /// A short, human-readable summary of the problem type.  It SHOULD NOT change from occurrence to occurrence of the problem, except for purposes of localization (e.g., using proactive content negotiation; see [RFC7231], Section 3.4). 
        /// </summary>
        /// <value>A short, human-readable summary of the problem type.  It SHOULD NOT change from occurrence to occurrence of the problem, except for purposes of localization (e.g., using proactive content negotiation; see [RFC7231], Section 3.4). </value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// A URI reference (see RFC3986) that identifies the problem type.  This specification encourages that, when dereferenced, it provide human-readable documentation for the problem type (e.g., using HTML [W3C.REC-html5-20141028]).  When this member is not present, its value is assumed to be \&quot;about:blank\&quot;. 
        /// </summary>
        /// <value>A URI reference (see RFC3986) that identifies the problem type.  This specification encourages that, when dereferenced, it provide human-readable documentation for the problem type (e.g., using HTML [W3C.REC-html5-20141028]).  When this member is not present, its value is assumed to be \&quot;about:blank\&quot;. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProblemResponsePartial {\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ProblemResponsePartial);
        }

        /// <summary>
        /// Returns true if ProblemResponsePartial instances are equal
        /// </summary>
        /// <param name="input">Instance of ProblemResponsePartial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProblemResponsePartial input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.Instance == input.Instance ||
                    (this.Instance != null &&
                    this.Instance.Equals(input.Instance))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.Instance != null)
                    hashCode = hashCode * 59 + this.Instance.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            // Status (int) minimum
            if(this.Status < (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, must be a value greater than or equal to 100.", new [] { "Status" });
            }

            yield break;
        }
    }

}
