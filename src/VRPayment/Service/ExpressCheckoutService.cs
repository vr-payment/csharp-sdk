/**
 * VR Payment C# SDK
 *
 * This library allows to interact with the VR Payment payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://www.vr-payment.de
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using VRPayment.Client;
using VRPayment.Model;

namespace VRPayment.Service
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExpressCheckoutServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new Express Checkout Session
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expressCheckoutSessionCreate"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExpressCheckoutCreateResponse</returns>
        ExpressCheckoutCreateResponse PostExpressCheckoutCreateSession(long space, ExpressCheckoutSessionCreate expressCheckoutSessionCreate, int operationIndex = 0);

        /// <summary>
        /// Create a new Express Checkout Session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expressCheckoutSessionCreate"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExpressCheckoutCreateResponse</returns>
        ApiResponse<ExpressCheckoutCreateResponse> PostExpressCheckoutCreateSessionWithHttpInfo(long space, ExpressCheckoutSessionCreate expressCheckoutSessionCreate, int operationIndex = 0);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExpressCheckoutService : IExpressCheckoutServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExpressCheckoutService : IExpressCheckoutService
    {

        private VRPayment.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressCheckoutService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExpressCheckoutService(VRPayment.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new VRPayment.Client.ApiClient(this.Configuration);
            ExceptionFactory = VRPayment.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressCheckoutService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ExpressCheckoutService(VRPayment.Client.ISynchronousClient client, VRPayment.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.Configuration = configuration;
            this.ExceptionFactory = VRPayment.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public VRPayment.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public VRPayment.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public VRPayment.Client.ExceptionFactory ExceptionFactory
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
        /// Create a new Express Checkout Session 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expressCheckoutSessionCreate"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExpressCheckoutCreateResponse</returns>
        public ExpressCheckoutCreateResponse PostExpressCheckoutCreateSession(long space, ExpressCheckoutSessionCreate expressCheckoutSessionCreate, int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<ExpressCheckoutCreateResponse> localVarResponse = PostExpressCheckoutCreateSessionWithHttpInfo(space, expressCheckoutSessionCreate);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Express Checkout Session 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expressCheckoutSessionCreate"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExpressCheckoutCreateResponse</returns>
        public VRPayment.Client.ApiResponse<ExpressCheckoutCreateResponse> PostExpressCheckoutCreateSessionWithHttpInfo(long space, ExpressCheckoutSessionCreate expressCheckoutSessionCreate, int operationIndex = 0)
        {
            // verify the required parameter 'expressCheckoutSessionCreate' is set
            if (expressCheckoutSessionCreate == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'expressCheckoutSessionCreate' when calling ExpressCheckoutService->PostExpressCheckoutCreateSession");
            }

            VRPayment.Client.RequestOptions localVarRequestOptions = new VRPayment.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = VRPayment.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = VRPayment.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = expressCheckoutSessionCreate;

            localVarRequestOptions.Operation = "ExpressCheckoutService.PostExpressCheckoutCreateSession";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Post<ExpressCheckoutCreateResponse>("/express-checkout/create-session",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostExpressCheckoutCreateSession", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
