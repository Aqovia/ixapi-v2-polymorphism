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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INetworkServicesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// List available &#x60;NetworkService&#x60;s.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="stateIsNot">Filter by state__is_not (optional)</param>
        /// <param name="managingAccount">Filter by managing_account (optional)</param>
        /// <param name="consumingAccount">Filter by consuming_account (optional)</param>
        /// <param name="externalRef">Filter by external_ref (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="pop">Filter by pop (optional)</param>
        /// <param name="productOffering">Filter by product_offering (optional)</param>
        /// <returns>List&lt;NetworkService&gt;</returns>
        List<NetworkService> NetworkServicesList (List<string> id = default(List<string>), string state = default(string), string stateIsNot = default(string), string managingAccount = default(string), string consumingAccount = default(string), string externalRef = default(string), string type = default(string), string pop = default(string), string productOffering = default(string));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// List available &#x60;NetworkService&#x60;s.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="stateIsNot">Filter by state__is_not (optional)</param>
        /// <param name="managingAccount">Filter by managing_account (optional)</param>
        /// <param name="consumingAccount">Filter by consuming_account (optional)</param>
        /// <param name="externalRef">Filter by external_ref (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="pop">Filter by pop (optional)</param>
        /// <param name="productOffering">Filter by product_offering (optional)</param>
        /// <returns>ApiResponse of List&lt;NetworkService&gt;</returns>
        ApiResponse<List<NetworkService>> NetworkServicesListWithHttpInfo (List<string> id = default(List<string>), string state = default(string), string stateIsNot = default(string), string managingAccount = default(string), string consumingAccount = default(string), string externalRef = default(string), string type = default(string), string pop = default(string), string productOffering = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// List available &#x60;NetworkService&#x60;s.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="stateIsNot">Filter by state__is_not (optional)</param>
        /// <param name="managingAccount">Filter by managing_account (optional)</param>
        /// <param name="consumingAccount">Filter by consuming_account (optional)</param>
        /// <param name="externalRef">Filter by external_ref (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="pop">Filter by pop (optional)</param>
        /// <param name="productOffering">Filter by product_offering (optional)</param>
        /// <returns>Task of List&lt;NetworkService&gt;</returns>
        System.Threading.Tasks.Task<List<NetworkService>> NetworkServicesListAsync (List<string> id = default(List<string>), string state = default(string), string stateIsNot = default(string), string managingAccount = default(string), string consumingAccount = default(string), string externalRef = default(string), string type = default(string), string pop = default(string), string productOffering = default(string));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// List available &#x60;NetworkService&#x60;s.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="stateIsNot">Filter by state__is_not (optional)</param>
        /// <param name="managingAccount">Filter by managing_account (optional)</param>
        /// <param name="consumingAccount">Filter by consuming_account (optional)</param>
        /// <param name="externalRef">Filter by external_ref (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="pop">Filter by pop (optional)</param>
        /// <param name="productOffering">Filter by product_offering (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;NetworkService&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<NetworkService>>> NetworkServicesListAsyncWithHttpInfo (List<string> id = default(List<string>), string state = default(string), string stateIsNot = default(string), string managingAccount = default(string), string consumingAccount = default(string), string externalRef = default(string), string type = default(string), string pop = default(string), string productOffering = default(string));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NetworkServicesApi : INetworkServicesApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkServicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NetworkServicesApi(String basePath)
        {
            this.Configuration = new Org.OpenAPITools.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkServicesApi"/> class
        /// </summary>
        /// <returns></returns>
        public NetworkServicesApi()
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.Default;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkServicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NetworkServicesApi(Org.OpenAPITools.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Org.OpenAPITools.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  List available &#x60;NetworkService&#x60;s.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="stateIsNot">Filter by state__is_not (optional)</param>
        /// <param name="managingAccount">Filter by managing_account (optional)</param>
        /// <param name="consumingAccount">Filter by consuming_account (optional)</param>
        /// <param name="externalRef">Filter by external_ref (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="pop">Filter by pop (optional)</param>
        /// <param name="productOffering">Filter by product_offering (optional)</param>
        /// <returns>List&lt;NetworkService&gt;</returns>
        public List<NetworkService> NetworkServicesList (List<string> id = default(List<string>), string state = default(string), string stateIsNot = default(string), string managingAccount = default(string), string consumingAccount = default(string), string externalRef = default(string), string type = default(string), string pop = default(string), string productOffering = default(string))
        {
             ApiResponse<List<NetworkService>> localVarResponse = NetworkServicesListWithHttpInfo(id, state, stateIsNot, managingAccount, consumingAccount, externalRef, type, pop, productOffering);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  List available &#x60;NetworkService&#x60;s.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="stateIsNot">Filter by state__is_not (optional)</param>
        /// <param name="managingAccount">Filter by managing_account (optional)</param>
        /// <param name="consumingAccount">Filter by consuming_account (optional)</param>
        /// <param name="externalRef">Filter by external_ref (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="pop">Filter by pop (optional)</param>
        /// <param name="productOffering">Filter by product_offering (optional)</param>
        /// <returns>ApiResponse of List&lt;NetworkService&gt;</returns>
        public ApiResponse<List<NetworkService>> NetworkServicesListWithHttpInfo (List<string> id = default(List<string>), string state = default(string), string stateIsNot = default(string), string managingAccount = default(string), string consumingAccount = default(string), string externalRef = default(string), string type = default(string), string pop = default(string), string productOffering = default(string))
        {

            var localVarPath = "/network-services";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id", id)); // query parameter
            if (state != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "state", state)); // query parameter
            if (stateIsNot != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "state__is_not", stateIsNot)); // query parameter
            if (managingAccount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "managing_account", managingAccount)); // query parameter
            if (consumingAccount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "consuming_account", consumingAccount)); // query parameter
            if (externalRef != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "external_ref", externalRef)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (pop != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "pop", pop)); // query parameter
            if (productOffering != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "product_offering", productOffering)); // query parameter

            // authentication (Bearer) required
            // http beerer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NetworkServicesList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<NetworkService>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<NetworkService>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<NetworkService>)));
        }

        /// <summary>
        ///  List available &#x60;NetworkService&#x60;s.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="stateIsNot">Filter by state__is_not (optional)</param>
        /// <param name="managingAccount">Filter by managing_account (optional)</param>
        /// <param name="consumingAccount">Filter by consuming_account (optional)</param>
        /// <param name="externalRef">Filter by external_ref (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="pop">Filter by pop (optional)</param>
        /// <param name="productOffering">Filter by product_offering (optional)</param>
        /// <returns>Task of List&lt;NetworkService&gt;</returns>
        public async System.Threading.Tasks.Task<List<NetworkService>> NetworkServicesListAsync (List<string> id = default(List<string>), string state = default(string), string stateIsNot = default(string), string managingAccount = default(string), string consumingAccount = default(string), string externalRef = default(string), string type = default(string), string pop = default(string), string productOffering = default(string))
        {
             ApiResponse<List<NetworkService>> localVarResponse = await NetworkServicesListAsyncWithHttpInfo(id, state, stateIsNot, managingAccount, consumingAccount, externalRef, type, pop, productOffering);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  List available &#x60;NetworkService&#x60;s.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="state">Filter by state (optional)</param>
        /// <param name="stateIsNot">Filter by state__is_not (optional)</param>
        /// <param name="managingAccount">Filter by managing_account (optional)</param>
        /// <param name="consumingAccount">Filter by consuming_account (optional)</param>
        /// <param name="externalRef">Filter by external_ref (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="pop">Filter by pop (optional)</param>
        /// <param name="productOffering">Filter by product_offering (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;NetworkService&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<NetworkService>>> NetworkServicesListAsyncWithHttpInfo (List<string> id = default(List<string>), string state = default(string), string stateIsNot = default(string), string managingAccount = default(string), string consumingAccount = default(string), string externalRef = default(string), string type = default(string), string pop = default(string), string productOffering = default(string))
        {

            var localVarPath = "/network-services";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id", id)); // query parameter
            if (state != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "state", state)); // query parameter
            if (stateIsNot != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "state__is_not", stateIsNot)); // query parameter
            if (managingAccount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "managing_account", managingAccount)); // query parameter
            if (consumingAccount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "consuming_account", consumingAccount)); // query parameter
            if (externalRef != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "external_ref", externalRef)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (pop != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "pop", pop)); // query parameter
            if (productOffering != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "product_offering", productOffering)); // query parameter

            // authentication (Bearer) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NetworkServicesList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<NetworkService>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<NetworkService>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<NetworkService>)));
        }

    }
}
