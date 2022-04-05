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
    /// Cloud Network Service
    /// </summary>
    [DataContract]
    public partial class CloudNetworkServicePartial :  IEquatable<CloudNetworkServicePartial>, IValidatableObject
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
            Cancelled = 12

        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudNetworkServicePartial" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CloudNetworkServicePartial() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudNetworkServicePartial" /> class.
        /// </summary>
        /// <param name="billingAccount">An account requires billing_information to be used as a &#x60;billing_account&#x60;..</param>
        /// <param name="capacity">The capacity of the service in Mbps. When null, the maximum capacity will be used..</param>
        /// <param name="chargedUntil">Your obligation to pay for the service will end on this date. Typically &#x60;≥ decommission_at&#x60;.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;..</param>
        /// <param name="cloudKey">cloudKey.</param>
        /// <param name="consumingAccount">The &#x60;id&#x60; of the account consuming a service.  Used to be &#x60;owning_customer&#x60;. .</param>
        /// <param name="contractRef">A reference to a contract. If no specific contract is used, a default MAY be chosen by the implementer. .</param>
        /// <param name="decommissionAt">The service will be decommissioned on this date.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;..</param>
        /// <param name="diversity">Same value as the corresponding &#x60;ProductOffering&#x60;.  The service can be delivered over multiple handovers from the exchange to the &#x60;service_provider&#x60;.  The &#x60;diversity&#x60; denotes the number of handovers between the exchange and the service provider. A value of two signals a redundant service.  Only one network service configuration for each &#x60;handover&#x60; and &#x60;cloud_vlan&#x60; can be created..</param>
        /// <param name="externalRef">Reference field, free to use for the API user..</param>
        /// <param name="id">id.</param>
        /// <param name="managingAccount">The &#x60;id&#x60; of the account responsible for managing the service via the API. A manager can read and update the state of entities. .</param>
        /// <param name="productOffering">productOffering.</param>
        /// <param name="providerRef">For a cloud network service with the exchange first workflow, the &#x60;provider_ref&#x60; will be a reference to a resource of the cloud provider. (E.g. the UUID of a virtual circuit.)  The &#x60;provider_ref&#x60; is managed by the exchange and its meaning may vary between different cloud services. .</param>
        /// <param name="purchaseOrder">Purchase Order ID which will be displayed on the invoice.  (default to &quot;&quot;).</param>
        /// <param name="state">state.</param>
        /// <param name="status">status.</param>
        /// <param name="type">type (required).</param>
        public CloudNetworkServicePartial(string billingAccount = default(string), int? capacity = default(int?), DateTime chargedUntil = default(DateTime), string cloudKey = default(string), string consumingAccount = default(string), string contractRef = default(string), DateTime decommissionAt = default(DateTime), int diversity = default(int), string externalRef = default(string), string id = default(string), string managingAccount = default(string), string productOffering = default(string), string providerRef = default(string), string purchaseOrder = "", StateEnum? state = default(StateEnum?), List<Status> status = default(List<Status>), string type = default(string))
        {
            this.Capacity = capacity;
            this.ContractRef = contractRef;
            this.ExternalRef = externalRef;
            this.ProviderRef = providerRef;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CloudNetworkServicePartial and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            this.BillingAccount = billingAccount;
            this.Capacity = capacity;
            this.ChargedUntil = chargedUntil;
            this.CloudKey = cloudKey;
            this.ConsumingAccount = consumingAccount;
            this.ContractRef = contractRef;
            this.DecommissionAt = decommissionAt;
            this.Diversity = diversity;
            this.ExternalRef = externalRef;
            this.Id = id;
            this.ManagingAccount = managingAccount;
            this.ProductOffering = productOffering;
            this.ProviderRef = providerRef;
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
        /// The capacity of the service in Mbps. When null, the maximum capacity will be used.
        /// </summary>
        /// <value>The capacity of the service in Mbps. When null, the maximum capacity will be used.</value>
        [DataMember(Name="capacity", EmitDefaultValue=true)]
        public int? Capacity { get; set; }

        /// <summary>
        /// Your obligation to pay for the service will end on this date. Typically &#x60;≥ decommission_at&#x60;.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;.
        /// </summary>
        /// <value>Your obligation to pay for the service will end on this date. Typically &#x60;≥ decommission_at&#x60;.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;.</value>
        [DataMember(Name="charged_until", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ChargedUntil { get; set; }

        /// <summary>
        /// Gets or Sets CloudKey
        /// </summary>
        [DataMember(Name="cloud_key", EmitDefaultValue=false)]
        public string CloudKey { get; set; }

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
        [DataMember(Name="contract_ref", EmitDefaultValue=true)]
        public string ContractRef { get; set; }

        /// <summary>
        /// The service will be decommissioned on this date.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;.
        /// </summary>
        /// <value>The service will be decommissioned on this date.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;.</value>
        [DataMember(Name="decommission_at", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DecommissionAt { get; set; }

        /// <summary>
        /// Same value as the corresponding &#x60;ProductOffering&#x60;.  The service can be delivered over multiple handovers from the exchange to the &#x60;service_provider&#x60;.  The &#x60;diversity&#x60; denotes the number of handovers between the exchange and the service provider. A value of two signals a redundant service.  Only one network service configuration for each &#x60;handover&#x60; and &#x60;cloud_vlan&#x60; can be created.
        /// </summary>
        /// <value>Same value as the corresponding &#x60;ProductOffering&#x60;.  The service can be delivered over multiple handovers from the exchange to the &#x60;service_provider&#x60;.  The &#x60;diversity&#x60; denotes the number of handovers between the exchange and the service provider. A value of two signals a redundant service.  Only one network service configuration for each &#x60;handover&#x60; and &#x60;cloud_vlan&#x60; can be created.</value>
        [DataMember(Name="diversity", EmitDefaultValue=false)]
        public int Diversity { get; set; }

        /// <summary>
        /// Reference field, free to use for the API user.
        /// </summary>
        /// <value>Reference field, free to use for the API user.</value>
        [DataMember(Name="external_ref", EmitDefaultValue=true)]
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
        /// For a cloud network service with the exchange first workflow, the &#x60;provider_ref&#x60; will be a reference to a resource of the cloud provider. (E.g. the UUID of a virtual circuit.)  The &#x60;provider_ref&#x60; is managed by the exchange and its meaning may vary between different cloud services. 
        /// </summary>
        /// <value>For a cloud network service with the exchange first workflow, the &#x60;provider_ref&#x60; will be a reference to a resource of the cloud provider. (E.g. the UUID of a virtual circuit.)  The &#x60;provider_ref&#x60; is managed by the exchange and its meaning may vary between different cloud services. </value>
        [DataMember(Name="provider_ref", EmitDefaultValue=true)]
        public string ProviderRef { get; set; }

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
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudNetworkServicePartial {\n");
            sb.Append("  BillingAccount: ").Append(BillingAccount).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  ChargedUntil: ").Append(ChargedUntil).Append("\n");
            sb.Append("  CloudKey: ").Append(CloudKey).Append("\n");
            sb.Append("  ConsumingAccount: ").Append(ConsumingAccount).Append("\n");
            sb.Append("  ContractRef: ").Append(ContractRef).Append("\n");
            sb.Append("  DecommissionAt: ").Append(DecommissionAt).Append("\n");
            sb.Append("  Diversity: ").Append(Diversity).Append("\n");
            sb.Append("  ExternalRef: ").Append(ExternalRef).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ManagingAccount: ").Append(ManagingAccount).Append("\n");
            sb.Append("  NscRequiredContactRoles: ").Append(NscRequiredContactRoles).Append("\n");
            sb.Append("  ProductOffering: ").Append(ProductOffering).Append("\n");
            sb.Append("  ProviderRef: ").Append(ProviderRef).Append("\n");
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
            return this.Equals(input as CloudNetworkServicePartial);
        }

        /// <summary>
        /// Returns true if CloudNetworkServicePartial instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudNetworkServicePartial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudNetworkServicePartial input)
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
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.ChargedUntil == input.ChargedUntil ||
                    (this.ChargedUntil != null &&
                    this.ChargedUntil.Equals(input.ChargedUntil))
                ) && 
                (
                    this.CloudKey == input.CloudKey ||
                    (this.CloudKey != null &&
                    this.CloudKey.Equals(input.CloudKey))
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
                    this.Diversity == input.Diversity ||
                    (this.Diversity != null &&
                    this.Diversity.Equals(input.Diversity))
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
                    this.ProviderRef == input.ProviderRef ||
                    (this.ProviderRef != null &&
                    this.ProviderRef.Equals(input.ProviderRef))
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
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.ChargedUntil != null)
                    hashCode = hashCode * 59 + this.ChargedUntil.GetHashCode();
                if (this.CloudKey != null)
                    hashCode = hashCode * 59 + this.CloudKey.GetHashCode();
                if (this.ConsumingAccount != null)
                    hashCode = hashCode * 59 + this.ConsumingAccount.GetHashCode();
                if (this.ContractRef != null)
                    hashCode = hashCode * 59 + this.ContractRef.GetHashCode();
                if (this.DecommissionAt != null)
                    hashCode = hashCode * 59 + this.DecommissionAt.GetHashCode();
                if (this.Diversity != null)
                    hashCode = hashCode * 59 + this.Diversity.GetHashCode();
                if (this.ExternalRef != null)
                    hashCode = hashCode * 59 + this.ExternalRef.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ManagingAccount != null)
                    hashCode = hashCode * 59 + this.ManagingAccount.GetHashCode();
                if (this.NscRequiredContactRoles != null)
                    hashCode = hashCode * 59 + this.NscRequiredContactRoles.GetHashCode();
                if (this.ProductOffering != null)
                    hashCode = hashCode * 59 + this.ProductOffering.GetHashCode();
                if (this.ProviderRef != null)
                    hashCode = hashCode * 59 + this.ProviderRef.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {

            
            // Capacity (int?) minimum
            if(this.Capacity < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Capacity, must be a value greater than or equal to 1.", new [] { "Capacity" });
            }

            // ContractRef (string) maxLength
            if(this.ContractRef != null && this.ContractRef.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractRef, length must be less than 128.", new [] { "ContractRef" });
            }

            

            
            // Diversity (int) minimum
            if(this.Diversity < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Diversity, must be a value greater than or equal to 1.", new [] { "Diversity" });
            }

            // ExternalRef (string) maxLength
            if(this.ExternalRef != null && this.ExternalRef.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExternalRef, length must be less than 128.", new [] { "ExternalRef" });
            }

            
            // PurchaseOrder (string) maxLength
            if(this.PurchaseOrder != null && this.PurchaseOrder.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PurchaseOrder, length must be less than 80.", new [] { "PurchaseOrder" });
            }

            
            yield break;
        }
    }

}
