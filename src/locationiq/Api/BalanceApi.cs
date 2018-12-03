/* 
 * LocationIQ
 *
 * LocationIQ provides flexible enterprise-grade location based solutions. We work with developers, startups and enterprises worldwide serving billions of requests everyday. This page provides an overview of the technical aspects of our API and will help you get started.
 *
 * OpenAPI spec version: 1.0.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using locationiq.Client;
using locationiq.Model;

namespace locationiq.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBalanceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The Balance API provides a count of request credits left in the user&#39;s account for the day. Balance is reset at midnight UTC everyday (00:00 UTC).
        /// </remarks>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Balance</returns>
        Balance Balance ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The Balance API provides a count of request credits left in the user&#39;s account for the day. Balance is reset at midnight UTC everyday (00:00 UTC).
        /// </remarks>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Balance</returns>
        ApiResponse<Balance> BalanceWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The Balance API provides a count of request credits left in the user&#39;s account for the day. Balance is reset at midnight UTC everyday (00:00 UTC).
        /// </remarks>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Balance</returns>
        System.Threading.Tasks.Task<Balance> BalanceAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The Balance API provides a count of request credits left in the user&#39;s account for the day. Balance is reset at midnight UTC everyday (00:00 UTC).
        /// </remarks>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Balance)</returns>
        System.Threading.Tasks.Task<ApiResponse<Balance>> BalanceAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BalanceApi : IBalanceApi
    {
        private locationiq.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BalanceApi(String basePath)
        {
            this.Configuration = new locationiq.Client.Configuration { BasePath = basePath };

            ExceptionFactory = locationiq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BalanceApi(locationiq.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = locationiq.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = locationiq.Client.Configuration.DefaultExceptionFactory;
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
        public locationiq.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public locationiq.Client.ExceptionFactory ExceptionFactory
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
        ///  The Balance API provides a count of request credits left in the user&#39;s account for the day. Balance is reset at midnight UTC everyday (00:00 UTC).
        /// </summary>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Balance</returns>
        public Balance Balance ()
        {
             ApiResponse<Balance> localVarResponse = BalanceWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  The Balance API provides a count of request credits left in the user&#39;s account for the day. Balance is reset at midnight UTC everyday (00:00 UTC).
        /// </summary>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Balance</returns>
        public ApiResponse< Balance > BalanceWithHttpInfo ()
        {

            var localVarPath = "/balance.php";
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


            // authentication (key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "key", this.Configuration.GetApiKeyWithPrefix("key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Balance", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Balance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Balance) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Balance)));
        }

        /// <summary>
        ///  The Balance API provides a count of request credits left in the user&#39;s account for the day. Balance is reset at midnight UTC everyday (00:00 UTC).
        /// </summary>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Balance</returns>
        public async System.Threading.Tasks.Task<Balance> BalanceAsync ()
        {
             ApiResponse<Balance> localVarResponse = await BalanceAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  The Balance API provides a count of request credits left in the user&#39;s account for the day. Balance is reset at midnight UTC everyday (00:00 UTC).
        /// </summary>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Balance)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Balance>> BalanceAsyncWithHttpInfo ()
        {

            var localVarPath = "/balance.php";
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


            // authentication (key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "key", this.Configuration.GetApiKeyWithPrefix("key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Balance", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Balance>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Balance) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Balance)));
        }

    }
}