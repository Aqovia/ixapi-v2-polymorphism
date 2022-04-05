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
    /// Exchange Lan Network Service
    /// </summary>
    [DataContract]
        public partial class ExchangeLanNetworkServicePartial :  IEquatable<ExchangeLanNetworkServicePartial>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum
        {
            /// <summary>
            /// Enum Requested for value: requested
            /// </summary>
            [EnumMember(Value = "requested")]
            Requested = 1,
            /// <summary>
            /// Enum Allocated for value: allocated
            /// </summary>
            [EnumMember(Value = "allocated")]
            Allocated = 2,
            /// <summary>
            /// Enum Testing for value: testing
            /// </summary>
            [EnumMember(Value = "testing")]
            Testing = 3,
            /// <summary>
            /// Enum Production for value: production
            /// </summary>
            [EnumMember(Value = "production")]
            Production = 4,
            /// <summary>
            /// Enum Productionchangepending for value: production_change_pending
            /// </summary>
            [EnumMember(Value = "production_change_pending")]
            Productionchangepending = 5,
            /// <summary>
            /// Enum Decommissionrequested for value: decommission_requested
            /// </summary>
            [EnumMember(Value = "decommission_requested")]
            Decommissionrequested = 6,
            /// <summary>
            /// Enum Decommissioned for value: decommissioned
            /// </summary>
            [EnumMember(Value = "decommissioned")]
            Decommissioned = 7,
            /// <summary>
            /// Enum Archived for value: archived
            /// </summary>
            [EnumMember(Value = "archived")]
            Archived = 8,
            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 9,
            /// <summary>
            /// Enum Operator for value: operator
            /// </summary>
            [EnumMember(Value = "operator")]
            Operator = 10,
            /// <summary>
            /// Enum Scheduled for value: scheduled
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled = 11,
            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 12        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeLanNetworkServicePartial" /> class.
        /// </summary>
        /// <param name="consumingAccount">The &#x60;id&#x60; of the account consuming a service.  Used to be &#x60;owning_customer&#x60;. .</param>
        /// <param name="externalRef">Reference field, free to use for the API user..</param>
        /// <param name="id">id.</param>
        /// <param name="ixfdbIxid">id of ixfdb.</param>
        /// <param name="managingAccount">The &#x60;id&#x60; of the account responsible for managing the service via the API. A manager can read and update the state of entities. .</param>
        /// <param name="metroAreaNetwork">Id of the &#x60;MetroAreaNetwork&#x60; where the exchange lan network service is directly provided.  Same as &#x60;service_metro_area_network&#x60; on the related &#x60;ProductOffering&#x60;. .</param>
        /// <param name="name">Exchange-dependent service name, will be shown on the invoice..</param>
        /// <param name="networkFeatures">networkFeatures.</param>
        /// <param name="peeringdbIxid">PeeringDB ixid.</param>
        /// <param name="productOffering">productOffering.</param>
        /// <param name="state">state.</param>
        /// <param name="status">status.</param>
        /// <param name="subnetV4">IPv4 subnet in [dot-decimal notation](https://en.wikipedia.org/wiki/Dot-decimal_notation) CIDR notation. .</param>
        /// <param name="subnetV6">IPv6 subnet in hexadecimal colon separated CIDR notation. .</param>
        /// <param name="type">type (required).</param>
        public ExchangeLanNetworkServicePartial(string consumingAccount = default(string), string externalRef = default(string), string id = default(string), int? ixfdbIxid = default(int?), string managingAccount = default(string), string metroAreaNetwork = default(string), string name = default(string), List<string> networkFeatures = default(List<string>), int? peeringdbIxid = default(int?), string productOffering = default(string), StateEnum? state = default(StateEnum?), List<Status> status = default(List<Status>), string subnetV4 = default(string), string subnetV6 = default(string), string type = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ExchangeLanNetworkServicePartial and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.ConsumingAccount = consumingAccount;
            this.ExternalRef = externalRef;
            this.Id = id;
            this.IxfdbIxid = ixfdbIxid;
            this.ManagingAccount = managingAccount;
            this.MetroAreaNetwork = metroAreaNetwork;
            this.Name = name;
            this.NetworkFeatures = networkFeatures;
            this.PeeringdbIxid = peeringdbIxid;
            this.ProductOffering = productOffering;
            this.State = state;
            this.Status = status;
            this.SubnetV4 = subnetV4;
            this.SubnetV6 = subnetV6;
        }
        
        /// <summary>
        /// The &#x60;id&#x60; of the account consuming a service.  Used to be &#x60;owning_customer&#x60;. 
        /// </summary>
        /// <value>The &#x60;id&#x60; of the account consuming a service.  Used to be &#x60;owning_customer&#x60;. </value>
        [DataMember(Name="consuming_account", EmitDefaultValue=false)]
        public string ConsumingAccount { get; set; }

        /// <summary>
        /// Reference field, free to use for the API user.
        /// </summary>
        /// <value>Reference field, free to use for the API user.</value>
        [DataMember(Name="external_ref", EmitDefaultValue=false)]
        public string ExternalRef { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// id of ixfdb
        /// </summary>
        /// <value>id of ixfdb</value>
        [DataMember(Name="ixfdb_ixid", EmitDefaultValue=false)]
        public int? IxfdbIxid { get; set; }

        /// <summary>
        /// The &#x60;id&#x60; of the account responsible for managing the service via the API. A manager can read and update the state of entities. 
        /// </summary>
        /// <value>The &#x60;id&#x60; of the account responsible for managing the service via the API. A manager can read and update the state of entities. </value>
        [DataMember(Name="managing_account", EmitDefaultValue=false)]
        public string ManagingAccount { get; set; }

        /// <summary>
        /// Id of the &#x60;MetroAreaNetwork&#x60; where the exchange lan network service is directly provided.  Same as &#x60;service_metro_area_network&#x60; on the related &#x60;ProductOffering&#x60;. 
        /// </summary>
        /// <value>Id of the &#x60;MetroAreaNetwork&#x60; where the exchange lan network service is directly provided.  Same as &#x60;service_metro_area_network&#x60; on the related &#x60;ProductOffering&#x60;. </value>
        [DataMember(Name="metro_area_network", EmitDefaultValue=false)]
        public string MetroAreaNetwork { get; set; }

        /// <summary>
        /// Exchange-dependent service name, will be shown on the invoice.
        /// </summary>
        /// <value>Exchange-dependent service name, will be shown on the invoice.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NetworkFeatures
        /// </summary>
        [DataMember(Name="network_features", EmitDefaultValue=false)]
        public List<string> NetworkFeatures { get; set; }

        /// <summary>
        /// The configuration will require at least one of each of the specified roles assigned to contacts.  The &#x60;RoleAssignment&#x60; is associated through the &#x60;role_assignments&#x60; list property of the network service configuration.
        /// </summary>
        /// <value>The configuration will require at least one of each of the specified roles assigned to contacts.  The &#x60;RoleAssignment&#x60; is associated through the &#x60;role_assignments&#x60; list property of the network service configuration.</value>
        [DataMember(Name="nsc_required_contact_roles", EmitDefaultValue=false)]
        public List<string> NscRequiredContactRoles { get; private set; }

        /// <summary>
        /// PeeringDB ixid
        /// </summary>
        /// <value>PeeringDB ixid</value>
        [DataMember(Name="peeringdb_ixid", EmitDefaultValue=false)]
        public int? PeeringdbIxid { get; set; }

        /// <summary>
        /// Gets or Sets ProductOffering
        /// </summary>
        [DataMember(Name="product_offering", EmitDefaultValue=false)]
        public string ProductOffering { get; set; }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public List<Status> Status { get; set; }

        /// <summary>
        /// IPv4 subnet in [dot-decimal notation](https://en.wikipedia.org/wiki/Dot-decimal_notation) CIDR notation. 
        /// </summary>
        /// <value>IPv4 subnet in [dot-decimal notation](https://en.wikipedia.org/wiki/Dot-decimal_notation) CIDR notation. </value>
        [DataMember(Name="subnet_v4", EmitDefaultValue=false)]
        public string SubnetV4 { get; set; }

        /// <summary>
        /// IPv6 subnet in hexadecimal colon separated CIDR notation. 
        /// </summary>
        /// <value>IPv6 subnet in hexadecimal colon separated CIDR notation. </value>
        [DataMember(Name="subnet_v6", EmitDefaultValue=false)]
        public string SubnetV6 { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangeLanNetworkServicePartial {\n");
            sb.Append("  ConsumingAccount: ").Append(ConsumingAccount).Append("\n");
            sb.Append("  ExternalRef: ").Append(ExternalRef).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IxfdbIxid: ").Append(IxfdbIxid).Append("\n");
            sb.Append("  ManagingAccount: ").Append(ManagingAccount).Append("\n");
            sb.Append("  MetroAreaNetwork: ").Append(MetroAreaNetwork).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NetworkFeatures: ").Append(NetworkFeatures).Append("\n");
            sb.Append("  NscRequiredContactRoles: ").Append(NscRequiredContactRoles).Append("\n");
            sb.Append("  PeeringdbIxid: ").Append(PeeringdbIxid).Append("\n");
            sb.Append("  ProductOffering: ").Append(ProductOffering).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubnetV4: ").Append(SubnetV4).Append("\n");
            sb.Append("  SubnetV6: ").Append(SubnetV6).Append("\n");
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
            return this.Equals(input as ExchangeLanNetworkServicePartial);
        }

        /// <summary>
        /// Returns true if ExchangeLanNetworkServicePartial instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeLanNetworkServicePartial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeLanNetworkServicePartial input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumingAccount == input.ConsumingAccount ||
                    (this.ConsumingAccount != null &&
                    this.ConsumingAccount.Equals(input.ConsumingAccount))
                ) && 
                (
                    this.ExternalRef == input.ExternalRef ||
                    (this.ExternalRef != null &&
                    this.ExternalRef.Equals(input.ExternalRef))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IxfdbIxid == input.IxfdbIxid ||
                    (this.IxfdbIxid != null &&
                    this.IxfdbIxid.Equals(input.IxfdbIxid))
                ) && 
                (
                    this.ManagingAccount == input.ManagingAccount ||
                    (this.ManagingAccount != null &&
                    this.ManagingAccount.Equals(input.ManagingAccount))
                ) && 
                (
                    this.MetroAreaNetwork == input.MetroAreaNetwork ||
                    (this.MetroAreaNetwork != null &&
                    this.MetroAreaNetwork.Equals(input.MetroAreaNetwork))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NetworkFeatures == input.NetworkFeatures ||
                    this.NetworkFeatures != null &&
                    input.NetworkFeatures != null &&
                    this.NetworkFeatures.SequenceEqual(input.NetworkFeatures)
                ) && 
                (
                    this.NscRequiredContactRoles == input.NscRequiredContactRoles ||
                    this.NscRequiredContactRoles != null &&
                    input.NscRequiredContactRoles != null &&
                    this.NscRequiredContactRoles.SequenceEqual(input.NscRequiredContactRoles)
                ) && 
                (
                    this.PeeringdbIxid == input.PeeringdbIxid ||
                    (this.PeeringdbIxid != null &&
                    this.PeeringdbIxid.Equals(input.PeeringdbIxid))
                ) && 
                (
                    this.ProductOffering == input.ProductOffering ||
                    (this.ProductOffering != null &&
                    this.ProductOffering.Equals(input.ProductOffering))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status != null &&
                    input.Status != null &&
                    this.Status.SequenceEqual(input.Status)
                ) && 
                (
                    this.SubnetV4 == input.SubnetV4 ||
                    (this.SubnetV4 != null &&
                    this.SubnetV4.Equals(input.SubnetV4))
                ) && 
                (
                    this.SubnetV6 == input.SubnetV6 ||
                    (this.SubnetV6 != null &&
                    this.SubnetV6.Equals(input.SubnetV6))
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
                if (this.ConsumingAccount != null)
                    hashCode = hashCode * 59 + this.ConsumingAccount.GetHashCode();
                if (this.ExternalRef != null)
                    hashCode = hashCode * 59 + this.ExternalRef.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IxfdbIxid != null)
                    hashCode = hashCode * 59 + this.IxfdbIxid.GetHashCode();
                if (this.ManagingAccount != null)
                    hashCode = hashCode * 59 + this.ManagingAccount.GetHashCode();
                if (this.MetroAreaNetwork != null)
                    hashCode = hashCode * 59 + this.MetroAreaNetwork.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetworkFeatures != null)
                    hashCode = hashCode * 59 + this.NetworkFeatures.GetHashCode();
                if (this.NscRequiredContactRoles != null)
                    hashCode = hashCode * 59 + this.NscRequiredContactRoles.GetHashCode();
                if (this.PeeringdbIxid != null)
                    hashCode = hashCode * 59 + this.PeeringdbIxid.GetHashCode();
                if (this.ProductOffering != null)
                    hashCode = hashCode * 59 + this.ProductOffering.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubnetV4 != null)
                    hashCode = hashCode * 59 + this.SubnetV4.GetHashCode();
                if (this.SubnetV6 != null)
                    hashCode = hashCode * 59 + this.SubnetV6.GetHashCode();
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
            yield break;
        }
    }
}
