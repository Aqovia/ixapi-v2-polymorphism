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
    /// ExchangeLanNetworkService
    /// </summary>
    [DataContract]
    public partial class ExchangeLanNetworkService : ExchangeLanNetworkServicePartial,  IEquatable<ExchangeLanNetworkService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeLanNetworkService" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExchangeLanNetworkService() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeLanNetworkService" /> class.
        /// </summary>
        /// <param name="consumingAccount">The &#x60;id&#x60; of the account consuming a service.  Used to be &#x60;owning_customer&#x60;.  (required).</param>
        /// <param name="externalRef">Reference field, free to use for the API user..</param>
        /// <param name="id">id (required).</param>
        /// <param name="ixfdbIxid">id of ixfdb.</param>
        /// <param name="managingAccount">The &#x60;id&#x60; of the account responsible for managing the service via the API. A manager can read and update the state of entities.  (required).</param>
        /// <param name="metroAreaNetwork">Id of the &#x60;MetroAreaNetwork&#x60; where the exchange lan network service is directly provided.  Same as &#x60;service_metro_area_network&#x60; on the related &#x60;ProductOffering&#x60;.  (required).</param>
        /// <param name="name">Exchange-dependent service name, will be shown on the invoice. (required).</param>
        /// <param name="networkFeatures">networkFeatures (required).</param>
        /// <param name="peeringdbIxid">PeeringDB ixid.</param>
        /// <param name="productOffering">productOffering.</param>
        /// <param name="state">state (required).</param>
        /// <param name="status">status.</param>
        /// <param name="subnetV4">IPv4 subnet in [dot-decimal notation](https://en.wikipedia.org/wiki/Dot-decimal_notation) CIDR notation.  (required).</param>
        /// <param name="subnetV6">IPv6 subnet in hexadecimal colon separated CIDR notation.  (required).</param>
        /// <param name="type">type (required).</param>
        public ExchangeLanNetworkService(string consumingAccount = default(string), string externalRef = default(string), string id = default(string), int? ixfdbIxid = default(int?), string managingAccount = default(string), string metroAreaNetwork = default(string), string name = default(string), List<string> networkFeatures = default(List<string>), int? peeringdbIxid = default(int?), string productOffering = default(string), StateEnum state = default(StateEnum), List<Status> status = default(List<Status>), string subnetV4 = default(string), string subnetV6 = default(string), string type = default(string)) : base(consumingAccount, externalRef, id, ixfdbIxid, managingAccount, metroAreaNetwork, name, networkFeatures, nscRequiredContactRoles, peeringdbIxid, productOffering, state, status, subnetV4, subnetV6, type)
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangeLanNetworkService {\n");
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
            return this.Equals(input as ExchangeLanNetworkService);
        }

        /// <summary>
        /// Returns true if ExchangeLanNetworkService instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeLanNetworkService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeLanNetworkService input)
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
