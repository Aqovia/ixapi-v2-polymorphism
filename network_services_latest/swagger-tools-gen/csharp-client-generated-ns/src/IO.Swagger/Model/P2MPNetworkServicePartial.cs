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
    /// P2MP Network Service
    /// </summary>
    [DataContract]
        public partial class P2MPNetworkServicePartial :  IEquatable<P2MPNetworkServicePartial>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="P2MPNetworkServicePartial" /> class.
        /// </summary>
        /// <param name="billingAccount">An account requires billing_information to be used as a &#x60;billing_account&#x60;..</param>
        /// <param name="chargedUntil">Your obligation to pay for the service will end on this date. Typically &#x60;≥ decommission_at&#x60;.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;..</param>
        /// <param name="consumingAccount">The &#x60;id&#x60; of the account consuming a service.  Used to be &#x60;owning_customer&#x60;. .</param>
        /// <param name="contractRef">A reference to a contract. If no specific contract is used, a default MAY be chosen by the implementer. .</param>
        /// <param name="decommissionAt">The service will be decommissioned on this date.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;..</param>
        /// <param name="externalRef">Reference field, free to use for the API user..</param>
        /// <param name="id">id.</param>
        /// <param name="managingAccount">The &#x60;id&#x60; of the account responsible for managing the service via the API. A manager can read and update the state of entities. .</param>
        /// <param name="memberJoiningRules">memberJoiningRules.</param>
        /// <param name="name">Name of the point to multi-point virtual circuit..</param>
        /// <param name="networkFeatures">networkFeatures.</param>
        /// <param name="productOffering">productOffering.</param>
        /// <param name="_public">A public p2mp network service can be joined by everyone on the exchange unless denied by a member-joining-rule.  Public network services are visible to other members of the IXP, however only &#x60;name&#x60;, &#x60;type&#x60;, &#x60;product_offering&#x60;, &#x60;consuming_account&#x60; and &#x60;managing_account&#x60; are made available.  Other required fields are redacted. (default to false).</param>
        /// <param name="purchaseOrder">Purchase Order ID which will be displayed on the invoice.  (default to &quot;&quot;).</param>
        /// <param name="state">state.</param>
        /// <param name="status">status.</param>
        /// <param name="type">type (required).</param>
        public P2MPNetworkServicePartial(string billingAccount = default(string), DateTime? chargedUntil = default(DateTime?), string consumingAccount = default(string), string contractRef = default(string), DateTime? decommissionAt = default(DateTime?), string externalRef = default(string), string id = default(string), string managingAccount = default(string), List<string> memberJoiningRules = default(List<string>), string name = default(string), List<string> networkFeatures = default(List<string>), string productOffering = default(string), bool? _public = false, string purchaseOrder = "", StateEnum? state = default(StateEnum?), List<Status> status = default(List<Status>), string type = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for P2MPNetworkServicePartial and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.BillingAccount = billingAccount;
            this.ChargedUntil = chargedUntil;
            this.ConsumingAccount = consumingAccount;
            this.ContractRef = contractRef;
            this.DecommissionAt = decommissionAt;
            this.ExternalRef = externalRef;
            this.Id = id;
            this.ManagingAccount = managingAccount;
            this.MemberJoiningRules = memberJoiningRules;
            this.Name = name;
            this.NetworkFeatures = networkFeatures;
            this.ProductOffering = productOffering;
            // use default value if no "_public" provided
            if (_public == null)
            {
                this._Public = false;
            }
            else
            {
                this._Public = _public;
            }
            // use default value if no "purchaseOrder" provided
            if (purchaseOrder == null)
            {
                this.PurchaseOrder = "";
            }
            else
            {
                this.PurchaseOrder = purchaseOrder;
            }
            this.State = state;
            this.Status = status;
        }
        
        /// <summary>
        /// An account requires billing_information to be used as a &#x60;billing_account&#x60;.
        /// </summary>
        /// <value>An account requires billing_information to be used as a &#x60;billing_account&#x60;.</value>
        [DataMember(Name="billing_account", EmitDefaultValue=false)]
        public string BillingAccount { get; set; }

        /// <summary>
        /// Your obligation to pay for the service will end on this date. Typically &#x60;≥ decommission_at&#x60;.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;.
        /// </summary>
        /// <value>Your obligation to pay for the service will end on this date. Typically &#x60;≥ decommission_at&#x60;.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;.</value>
        [DataMember(Name="charged_until", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ChargedUntil { get; set; }

        /// <summary>
        /// The &#x60;id&#x60; of the account consuming a service.  Used to be &#x60;owning_customer&#x60;. 
        /// </summary>
        /// <value>The &#x60;id&#x60; of the account consuming a service.  Used to be &#x60;owning_customer&#x60;. </value>
        [DataMember(Name="consuming_account", EmitDefaultValue=false)]
        public string ConsumingAccount { get; set; }

        /// <summary>
        /// A reference to a contract. If no specific contract is used, a default MAY be chosen by the implementer. 
        /// </summary>
        /// <value>A reference to a contract. If no specific contract is used, a default MAY be chosen by the implementer. </value>
        [DataMember(Name="contract_ref", EmitDefaultValue=false)]
        public string ContractRef { get; set; }

        /// <summary>
        /// The service will be decommissioned on this date.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;.
        /// </summary>
        /// <value>The service will be decommissioned on this date.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;.</value>
        [DataMember(Name="decommission_at", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DecommissionAt { get; set; }

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
        /// The &#x60;id&#x60; of the account responsible for managing the service via the API. A manager can read and update the state of entities. 
        /// </summary>
        /// <value>The &#x60;id&#x60; of the account responsible for managing the service via the API. A manager can read and update the state of entities. </value>
        [DataMember(Name="managing_account", EmitDefaultValue=false)]
        public string ManagingAccount { get; set; }

        /// <summary>
        /// Gets or Sets MemberJoiningRules
        /// </summary>
        [DataMember(Name="member_joining_rules", EmitDefaultValue=false)]
        public List<string> MemberJoiningRules { get; set; }

        /// <summary>
        /// Name of the point to multi-point virtual circuit.
        /// </summary>
        /// <value>Name of the point to multi-point virtual circuit.</value>
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
        /// Gets or Sets ProductOffering
        /// </summary>
        [DataMember(Name="product_offering", EmitDefaultValue=false)]
        public string ProductOffering { get; set; }

        /// <summary>
        /// A public p2mp network service can be joined by everyone on the exchange unless denied by a member-joining-rule.  Public network services are visible to other members of the IXP, however only &#x60;name&#x60;, &#x60;type&#x60;, &#x60;product_offering&#x60;, &#x60;consuming_account&#x60; and &#x60;managing_account&#x60; are made available.  Other required fields are redacted.
        /// </summary>
        /// <value>A public p2mp network service can be joined by everyone on the exchange unless denied by a member-joining-rule.  Public network services are visible to other members of the IXP, however only &#x60;name&#x60;, &#x60;type&#x60;, &#x60;product_offering&#x60;, &#x60;consuming_account&#x60; and &#x60;managing_account&#x60; are made available.  Other required fields are redacted.</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        public bool? _Public { get; set; }

        /// <summary>
        /// Purchase Order ID which will be displayed on the invoice. 
        /// </summary>
        /// <value>Purchase Order ID which will be displayed on the invoice. </value>
        [DataMember(Name="purchase_order", EmitDefaultValue=false)]
        public string PurchaseOrder { get; set; }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public List<Status> Status { get; set; }

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
            sb.Append("class P2MPNetworkServicePartial {\n");
            sb.Append("  BillingAccount: ").Append(BillingAccount).Append("\n");
            sb.Append("  ChargedUntil: ").Append(ChargedUntil).Append("\n");
            sb.Append("  ConsumingAccount: ").Append(ConsumingAccount).Append("\n");
            sb.Append("  ContractRef: ").Append(ContractRef).Append("\n");
            sb.Append("  DecommissionAt: ").Append(DecommissionAt).Append("\n");
            sb.Append("  ExternalRef: ").Append(ExternalRef).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ManagingAccount: ").Append(ManagingAccount).Append("\n");
            sb.Append("  MemberJoiningRules: ").Append(MemberJoiningRules).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NetworkFeatures: ").Append(NetworkFeatures).Append("\n");
            sb.Append("  NscRequiredContactRoles: ").Append(NscRequiredContactRoles).Append("\n");
            sb.Append("  ProductOffering: ").Append(ProductOffering).Append("\n");
            sb.Append("  _Public: ").Append(_Public).Append("\n");
            sb.Append("  PurchaseOrder: ").Append(PurchaseOrder).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as P2MPNetworkServicePartial);
        }

        /// <summary>
        /// Returns true if P2MPNetworkServicePartial instances are equal
        /// </summary>
        /// <param name="input">Instance of P2MPNetworkServicePartial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(P2MPNetworkServicePartial input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillingAccount == input.BillingAccount ||
                    (this.BillingAccount != null &&
                    this.BillingAccount.Equals(input.BillingAccount))
                ) && 
                (
                    this.ChargedUntil == input.ChargedUntil ||
                    (this.ChargedUntil != null &&
                    this.ChargedUntil.Equals(input.ChargedUntil))
                ) && 
                (
                    this.ConsumingAccount == input.ConsumingAccount ||
                    (this.ConsumingAccount != null &&
                    this.ConsumingAccount.Equals(input.ConsumingAccount))
                ) && 
                (
                    this.ContractRef == input.ContractRef ||
                    (this.ContractRef != null &&
                    this.ContractRef.Equals(input.ContractRef))
                ) && 
                (
                    this.DecommissionAt == input.DecommissionAt ||
                    (this.DecommissionAt != null &&
                    this.DecommissionAt.Equals(input.DecommissionAt))
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
                    this.ManagingAccount == input.ManagingAccount ||
                    (this.ManagingAccount != null &&
                    this.ManagingAccount.Equals(input.ManagingAccount))
                ) && 
                (
                    this.MemberJoiningRules == input.MemberJoiningRules ||
                    this.MemberJoiningRules != null &&
                    input.MemberJoiningRules != null &&
                    this.MemberJoiningRules.SequenceEqual(input.MemberJoiningRules)
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
                    this.ProductOffering == input.ProductOffering ||
                    (this.ProductOffering != null &&
                    this.ProductOffering.Equals(input.ProductOffering))
                ) && 
                (
                    this._Public == input._Public ||
                    (this._Public != null &&
                    this._Public.Equals(input._Public))
                ) && 
                (
                    this.PurchaseOrder == input.PurchaseOrder ||
                    (this.PurchaseOrder != null &&
                    this.PurchaseOrder.Equals(input.PurchaseOrder))
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
                if (this.BillingAccount != null)
                    hashCode = hashCode * 59 + this.BillingAccount.GetHashCode();
                if (this.ChargedUntil != null)
                    hashCode = hashCode * 59 + this.ChargedUntil.GetHashCode();
                if (this.ConsumingAccount != null)
                    hashCode = hashCode * 59 + this.ConsumingAccount.GetHashCode();
                if (this.ContractRef != null)
                    hashCode = hashCode * 59 + this.ContractRef.GetHashCode();
                if (this.DecommissionAt != null)
                    hashCode = hashCode * 59 + this.DecommissionAt.GetHashCode();
                if (this.ExternalRef != null)
                    hashCode = hashCode * 59 + this.ExternalRef.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ManagingAccount != null)
                    hashCode = hashCode * 59 + this.ManagingAccount.GetHashCode();
                if (this.MemberJoiningRules != null)
                    hashCode = hashCode * 59 + this.MemberJoiningRules.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetworkFeatures != null)
                    hashCode = hashCode * 59 + this.NetworkFeatures.GetHashCode();
                if (this.NscRequiredContactRoles != null)
                    hashCode = hashCode * 59 + this.NscRequiredContactRoles.GetHashCode();
                if (this.ProductOffering != null)
                    hashCode = hashCode * 59 + this.ProductOffering.GetHashCode();
                if (this._Public != null)
                    hashCode = hashCode * 59 + this._Public.GetHashCode();
                if (this.PurchaseOrder != null)
                    hashCode = hashCode * 59 + this.PurchaseOrder.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
