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
    public interface IPaymentWebAppsServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a connector
        /// </summary>
        /// <remarks>
        /// Permanently deletes a connector. It cannot be undone.
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorExternalId">The unique identifier assigned during connector&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeletePaymentWebAppsConnectorsConnectorExternalId(string connectorExternalId, long space, int operationIndex = 0);

        /// <summary>
        /// Delete a connector
        /// </summary>
        /// <remarks>
        /// Permanently deletes a connector. It cannot be undone.
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorExternalId">The unique identifier assigned during connector&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePaymentWebAppsConnectorsConnectorExternalIdWithHttpInfo(string connectorExternalId, long space, int operationIndex = 0);

        /// <summary>
        /// Delete a processor
        /// </summary>
        /// <remarks>
        /// Permanently deletes a processor. It cannot be undone.
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId">The unique identifier assigned during processor&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeletePaymentWebAppsProcessorsExternalId(string externalId, long space, int operationIndex = 0);

        /// <summary>
        /// Delete a processor
        /// </summary>
        /// <remarks>
        /// Permanently deletes a processor. It cannot be undone.
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId">The unique identifier assigned during processor&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePaymentWebAppsProcessorsExternalIdWithHttpInfo(string externalId, long space, int operationIndex = 0);

        /// <summary>
        /// Update a charge attempt
        /// </summary>
        /// <remarks>
        /// Updates the state of a charge attempt for transactions created with a processor linked to the invoking web app, returning the specified charge attempt.
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppChargeAttemptUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ChargeAttempt</returns>
        ChargeAttempt PatchPaymentWebAppsChargeAttemptsId(long id, long space, PaymentAppChargeAttemptUpdate paymentAppChargeAttemptUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Update a charge attempt
        /// </summary>
        /// <remarks>
        /// Updates the state of a charge attempt for transactions created with a processor linked to the invoking web app, returning the specified charge attempt.
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppChargeAttemptUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ChargeAttempt</returns>
        ApiResponse<ChargeAttempt> PatchPaymentWebAppsChargeAttemptsIdWithHttpInfo(long id, long space, PaymentAppChargeAttemptUpdate paymentAppChargeAttemptUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Update a completion
        /// </summary>
        /// <remarks>
        /// Updates the state of a completion for transactions created with a processor linked to the invoking web app, returning the specified completion.
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppCompletionUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TransactionCompletion</returns>
        TransactionCompletion PatchPaymentWebAppsCompletionsId(long id, long space, PaymentAppCompletionUpdate paymentAppCompletionUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Update a completion
        /// </summary>
        /// <remarks>
        /// Updates the state of a completion for transactions created with a processor linked to the invoking web app, returning the specified completion.
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppCompletionUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TransactionCompletion</returns>
        ApiResponse<TransactionCompletion> PatchPaymentWebAppsCompletionsIdWithHttpInfo(long id, long space, PaymentAppCompletionUpdate paymentAppCompletionUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Update a connector
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorExternalId">The unique identifier assigned during connector&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppConnectorDetails"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaymentAppConnector</returns>
        PaymentAppConnector PatchPaymentWebAppsConnectorsConnectorExternalId(string connectorExternalId, long space, PaymentAppConnectorDetails paymentAppConnectorDetails, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Update a connector
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorExternalId">The unique identifier assigned during connector&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppConnectorDetails"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaymentAppConnector</returns>
        ApiResponse<PaymentAppConnector> PatchPaymentWebAppsConnectorsConnectorExternalIdWithHttpInfo(string connectorExternalId, long space, PaymentAppConnectorDetails paymentAppConnectorDetails, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Update a processor
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppProcessorDetails"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaymentAppProcessor</returns>
        PaymentAppProcessor PatchPaymentWebAppsProcessorsExternalId(string externalId, long space, PaymentAppProcessorDetails paymentAppProcessorDetails, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Update a processor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppProcessorDetails"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaymentAppProcessor</returns>
        ApiResponse<PaymentAppProcessor> PatchPaymentWebAppsProcessorsExternalIdWithHttpInfo(string externalId, long space, PaymentAppProcessorDetails paymentAppProcessorDetails, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Update a refund
        /// </summary>
        /// <remarks>
        /// Updates the state of a refund for transactions created with a processor linked to the invoking web app, returning the specified refund.
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppRefundUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Refund</returns>
        Refund PatchPaymentWebAppsRefundsId(long id, long space, PaymentAppRefundUpdate paymentAppRefundUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Update a refund
        /// </summary>
        /// <remarks>
        /// Updates the state of a refund for transactions created with a processor linked to the invoking web app, returning the specified refund.
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppRefundUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Refund</returns>
        ApiResponse<Refund> PatchPaymentWebAppsRefundsIdWithHttpInfo(long id, long space, PaymentAppRefundUpdate paymentAppRefundUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Update a void
        /// </summary>
        /// <remarks>
        /// Updates the state of a void for transactions created with a processor linked to the invoking web app, returning the specified void.
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppVoidUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TransactionVoid</returns>
        TransactionVoid PatchPaymentWebAppsVoidsId(long id, long space, PaymentAppVoidUpdate paymentAppVoidUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Update a void
        /// </summary>
        /// <remarks>
        /// Updates the state of a void for transactions created with a processor linked to the invoking web app, returning the specified void.
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppVoidUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TransactionVoid</returns>
        ApiResponse<TransactionVoid> PatchPaymentWebAppsVoidsIdWithHttpInfo(long id, long space, PaymentAppVoidUpdate paymentAppVoidUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Create a processor
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppProcessorDetailsCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaymentAppProcessor</returns>
        PaymentAppProcessor PostPaymentWebAppsProcessors(long space, PaymentAppProcessorDetailsCreate paymentAppProcessorDetailsCreate, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Create a processor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppProcessorDetailsCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaymentAppProcessor</returns>
        ApiResponse<PaymentAppProcessor> PostPaymentWebAppsProcessorsWithHttpInfo(long space, PaymentAppProcessorDetailsCreate paymentAppProcessorDetailsCreate, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Activate a processor for production
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId">The unique identifier assigned during processor&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaymentAppProcessor</returns>
        PaymentAppProcessor PostPaymentWebAppsProcessorsExternalIdActivateForProduction(string externalId, long space, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Activate a processor for production
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId">The unique identifier assigned during processor&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaymentAppProcessor</returns>
        ApiResponse<PaymentAppProcessor> PostPaymentWebAppsProcessorsExternalIdActivateForProductionWithHttpInfo(string externalId, long space, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Create a connector
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId">The unique identifier assigned during processor&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppConnectorDetailsCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaymentAppConnector</returns>
        PaymentAppConnector PostPaymentWebAppsProcessorsExternalIdConnectors(string externalId, long space, PaymentAppConnectorDetailsCreate paymentAppConnectorDetailsCreate, List<string>? expand = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Create a connector
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId">The unique identifier assigned during processor&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppConnectorDetailsCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaymentAppConnector</returns>
        ApiResponse<PaymentAppConnector> PostPaymentWebAppsProcessorsExternalIdConnectorsWithHttpInfo(string externalId, long space, PaymentAppConnectorDetailsCreate paymentAppConnectorDetailsCreate, List<string>? expand = default(List<string>?), int operationIndex = 0);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentWebAppsService : IPaymentWebAppsServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentWebAppsService : IPaymentWebAppsService
    {

        private VRPayment.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentWebAppsService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PaymentWebAppsService(VRPayment.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new VRPayment.Client.ApiClient(this.Configuration);
            ExceptionFactory = VRPayment.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentWebAppsService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PaymentWebAppsService(VRPayment.Client.ISynchronousClient client, VRPayment.Client.IReadableConfiguration configuration)
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
        /// Delete a connector Permanently deletes a connector. It cannot be undone.
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorExternalId">The unique identifier assigned during connector&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeletePaymentWebAppsConnectorsConnectorExternalId(string connectorExternalId, long space, int operationIndex = 0)
        {
            DeletePaymentWebAppsConnectorsConnectorExternalIdWithHttpInfo(connectorExternalId, space);
        }

        /// <summary>
        /// Delete a connector Permanently deletes a connector. It cannot be undone.
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorExternalId">The unique identifier assigned during connector&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public VRPayment.Client.ApiResponse<Object> DeletePaymentWebAppsConnectorsConnectorExternalIdWithHttpInfo(string connectorExternalId, long space, int operationIndex = 0)
        {
            // verify the required parameter 'connectorExternalId' is set
            if (connectorExternalId == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'connectorExternalId' when calling PaymentWebAppsService->DeletePaymentWebAppsConnectorsConnectorExternalId");
            }

            VRPayment.Client.RequestOptions localVarRequestOptions = new VRPayment.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.PathParameters.Add("connectorExternalId", VRPayment.Client.ClientUtils.ParameterToString(connectorExternalId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "PaymentWebAppsService.DeletePaymentWebAppsConnectorsConnectorExternalId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/payment/web-apps/connectors/{connectorExternalId}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePaymentWebAppsConnectorsConnectorExternalId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Delete a processor Permanently deletes a processor. It cannot be undone.
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId">The unique identifier assigned during processor&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeletePaymentWebAppsProcessorsExternalId(string externalId, long space, int operationIndex = 0)
        {
            DeletePaymentWebAppsProcessorsExternalIdWithHttpInfo(externalId, space);
        }

        /// <summary>
        /// Delete a processor Permanently deletes a processor. It cannot be undone.
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId">The unique identifier assigned during processor&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public VRPayment.Client.ApiResponse<Object> DeletePaymentWebAppsProcessorsExternalIdWithHttpInfo(string externalId, long space, int operationIndex = 0)
        {
            // verify the required parameter 'externalId' is set
            if (externalId == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'externalId' when calling PaymentWebAppsService->DeletePaymentWebAppsProcessorsExternalId");
            }

            VRPayment.Client.RequestOptions localVarRequestOptions = new VRPayment.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.PathParameters.Add("externalId", VRPayment.Client.ClientUtils.ParameterToString(externalId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "PaymentWebAppsService.DeletePaymentWebAppsProcessorsExternalId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/payment/web-apps/processors/{externalId}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePaymentWebAppsProcessorsExternalId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Update a charge attempt Updates the state of a charge attempt for transactions created with a processor linked to the invoking web app, returning the specified charge attempt.
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppChargeAttemptUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ChargeAttempt</returns>
        public ChargeAttempt PatchPaymentWebAppsChargeAttemptsId(long id, long space, PaymentAppChargeAttemptUpdate paymentAppChargeAttemptUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<ChargeAttempt> localVarResponse = PatchPaymentWebAppsChargeAttemptsIdWithHttpInfo(id, space, paymentAppChargeAttemptUpdate, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a charge attempt Updates the state of a charge attempt for transactions created with a processor linked to the invoking web app, returning the specified charge attempt.
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppChargeAttemptUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ChargeAttempt</returns>
        public VRPayment.Client.ApiResponse<ChargeAttempt> PatchPaymentWebAppsChargeAttemptsIdWithHttpInfo(long id, long space, PaymentAppChargeAttemptUpdate paymentAppChargeAttemptUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            // verify the required parameter 'paymentAppChargeAttemptUpdate' is set
            if (paymentAppChargeAttemptUpdate == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'paymentAppChargeAttemptUpdate' when calling PaymentWebAppsService->PatchPaymentWebAppsChargeAttemptsId");
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

            localVarRequestOptions.PathParameters.Add("id", VRPayment.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = paymentAppChargeAttemptUpdate;

            localVarRequestOptions.Operation = "PaymentWebAppsService.PatchPaymentWebAppsChargeAttemptsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Patch<ChargeAttempt>("/payment/web-apps/charge-attempts/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchPaymentWebAppsChargeAttemptsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Update a completion Updates the state of a completion for transactions created with a processor linked to the invoking web app, returning the specified completion.
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppCompletionUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TransactionCompletion</returns>
        public TransactionCompletion PatchPaymentWebAppsCompletionsId(long id, long space, PaymentAppCompletionUpdate paymentAppCompletionUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<TransactionCompletion> localVarResponse = PatchPaymentWebAppsCompletionsIdWithHttpInfo(id, space, paymentAppCompletionUpdate, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a completion Updates the state of a completion for transactions created with a processor linked to the invoking web app, returning the specified completion.
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppCompletionUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TransactionCompletion</returns>
        public VRPayment.Client.ApiResponse<TransactionCompletion> PatchPaymentWebAppsCompletionsIdWithHttpInfo(long id, long space, PaymentAppCompletionUpdate paymentAppCompletionUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            // verify the required parameter 'paymentAppCompletionUpdate' is set
            if (paymentAppCompletionUpdate == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'paymentAppCompletionUpdate' when calling PaymentWebAppsService->PatchPaymentWebAppsCompletionsId");
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

            localVarRequestOptions.PathParameters.Add("id", VRPayment.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = paymentAppCompletionUpdate;

            localVarRequestOptions.Operation = "PaymentWebAppsService.PatchPaymentWebAppsCompletionsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Patch<TransactionCompletion>("/payment/web-apps/completions/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchPaymentWebAppsCompletionsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Update a connector 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorExternalId">The unique identifier assigned during connector&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppConnectorDetails"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaymentAppConnector</returns>
        public PaymentAppConnector PatchPaymentWebAppsConnectorsConnectorExternalId(string connectorExternalId, long space, PaymentAppConnectorDetails paymentAppConnectorDetails, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<PaymentAppConnector> localVarResponse = PatchPaymentWebAppsConnectorsConnectorExternalIdWithHttpInfo(connectorExternalId, space, paymentAppConnectorDetails, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a connector 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectorExternalId">The unique identifier assigned during connector&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppConnectorDetails"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaymentAppConnector</returns>
        public VRPayment.Client.ApiResponse<PaymentAppConnector> PatchPaymentWebAppsConnectorsConnectorExternalIdWithHttpInfo(string connectorExternalId, long space, PaymentAppConnectorDetails paymentAppConnectorDetails, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            // verify the required parameter 'connectorExternalId' is set
            if (connectorExternalId == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'connectorExternalId' when calling PaymentWebAppsService->PatchPaymentWebAppsConnectorsConnectorExternalId");
            }

            // verify the required parameter 'paymentAppConnectorDetails' is set
            if (paymentAppConnectorDetails == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'paymentAppConnectorDetails' when calling PaymentWebAppsService->PatchPaymentWebAppsConnectorsConnectorExternalId");
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

            localVarRequestOptions.PathParameters.Add("connectorExternalId", VRPayment.Client.ClientUtils.ParameterToString(connectorExternalId)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = paymentAppConnectorDetails;

            localVarRequestOptions.Operation = "PaymentWebAppsService.PatchPaymentWebAppsConnectorsConnectorExternalId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Patch<PaymentAppConnector>("/payment/web-apps/connectors/{connectorExternalId}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchPaymentWebAppsConnectorsConnectorExternalId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Update a processor 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppProcessorDetails"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaymentAppProcessor</returns>
        public PaymentAppProcessor PatchPaymentWebAppsProcessorsExternalId(string externalId, long space, PaymentAppProcessorDetails paymentAppProcessorDetails, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<PaymentAppProcessor> localVarResponse = PatchPaymentWebAppsProcessorsExternalIdWithHttpInfo(externalId, space, paymentAppProcessorDetails, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a processor 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppProcessorDetails"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaymentAppProcessor</returns>
        public VRPayment.Client.ApiResponse<PaymentAppProcessor> PatchPaymentWebAppsProcessorsExternalIdWithHttpInfo(string externalId, long space, PaymentAppProcessorDetails paymentAppProcessorDetails, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            // verify the required parameter 'externalId' is set
            if (externalId == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'externalId' when calling PaymentWebAppsService->PatchPaymentWebAppsProcessorsExternalId");
            }

            // verify the required parameter 'paymentAppProcessorDetails' is set
            if (paymentAppProcessorDetails == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'paymentAppProcessorDetails' when calling PaymentWebAppsService->PatchPaymentWebAppsProcessorsExternalId");
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

            localVarRequestOptions.PathParameters.Add("externalId", VRPayment.Client.ClientUtils.ParameterToString(externalId)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = paymentAppProcessorDetails;

            localVarRequestOptions.Operation = "PaymentWebAppsService.PatchPaymentWebAppsProcessorsExternalId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Patch<PaymentAppProcessor>("/payment/web-apps/processors/{externalId}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchPaymentWebAppsProcessorsExternalId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Update a refund Updates the state of a refund for transactions created with a processor linked to the invoking web app, returning the specified refund.
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppRefundUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Refund</returns>
        public Refund PatchPaymentWebAppsRefundsId(long id, long space, PaymentAppRefundUpdate paymentAppRefundUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<Refund> localVarResponse = PatchPaymentWebAppsRefundsIdWithHttpInfo(id, space, paymentAppRefundUpdate, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a refund Updates the state of a refund for transactions created with a processor linked to the invoking web app, returning the specified refund.
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppRefundUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Refund</returns>
        public VRPayment.Client.ApiResponse<Refund> PatchPaymentWebAppsRefundsIdWithHttpInfo(long id, long space, PaymentAppRefundUpdate paymentAppRefundUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            // verify the required parameter 'paymentAppRefundUpdate' is set
            if (paymentAppRefundUpdate == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'paymentAppRefundUpdate' when calling PaymentWebAppsService->PatchPaymentWebAppsRefundsId");
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

            localVarRequestOptions.PathParameters.Add("id", VRPayment.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = paymentAppRefundUpdate;

            localVarRequestOptions.Operation = "PaymentWebAppsService.PatchPaymentWebAppsRefundsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Patch<Refund>("/payment/web-apps/refunds/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchPaymentWebAppsRefundsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Update a void Updates the state of a void for transactions created with a processor linked to the invoking web app, returning the specified void.
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppVoidUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TransactionVoid</returns>
        public TransactionVoid PatchPaymentWebAppsVoidsId(long id, long space, PaymentAppVoidUpdate paymentAppVoidUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<TransactionVoid> localVarResponse = PatchPaymentWebAppsVoidsIdWithHttpInfo(id, space, paymentAppVoidUpdate, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a void Updates the state of a void for transactions created with a processor linked to the invoking web app, returning the specified void.
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppVoidUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TransactionVoid</returns>
        public VRPayment.Client.ApiResponse<TransactionVoid> PatchPaymentWebAppsVoidsIdWithHttpInfo(long id, long space, PaymentAppVoidUpdate paymentAppVoidUpdate, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            // verify the required parameter 'paymentAppVoidUpdate' is set
            if (paymentAppVoidUpdate == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'paymentAppVoidUpdate' when calling PaymentWebAppsService->PatchPaymentWebAppsVoidsId");
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

            localVarRequestOptions.PathParameters.Add("id", VRPayment.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = paymentAppVoidUpdate;

            localVarRequestOptions.Operation = "PaymentWebAppsService.PatchPaymentWebAppsVoidsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Patch<TransactionVoid>("/payment/web-apps/voids/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchPaymentWebAppsVoidsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Create a processor 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppProcessorDetailsCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaymentAppProcessor</returns>
        public PaymentAppProcessor PostPaymentWebAppsProcessors(long space, PaymentAppProcessorDetailsCreate paymentAppProcessorDetailsCreate, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<PaymentAppProcessor> localVarResponse = PostPaymentWebAppsProcessorsWithHttpInfo(space, paymentAppProcessorDetailsCreate, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a processor 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppProcessorDetailsCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaymentAppProcessor</returns>
        public VRPayment.Client.ApiResponse<PaymentAppProcessor> PostPaymentWebAppsProcessorsWithHttpInfo(long space, PaymentAppProcessorDetailsCreate paymentAppProcessorDetailsCreate, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            // verify the required parameter 'paymentAppProcessorDetailsCreate' is set
            if (paymentAppProcessorDetailsCreate == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'paymentAppProcessorDetailsCreate' when calling PaymentWebAppsService->PostPaymentWebAppsProcessors");
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

            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = paymentAppProcessorDetailsCreate;

            localVarRequestOptions.Operation = "PaymentWebAppsService.PostPaymentWebAppsProcessors";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Post<PaymentAppProcessor>("/payment/web-apps/processors",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostPaymentWebAppsProcessors", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Activate a processor for production 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId">The unique identifier assigned during processor&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaymentAppProcessor</returns>
        public PaymentAppProcessor PostPaymentWebAppsProcessorsExternalIdActivateForProduction(string externalId, long space, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<PaymentAppProcessor> localVarResponse = PostPaymentWebAppsProcessorsExternalIdActivateForProductionWithHttpInfo(externalId, space, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Activate a processor for production 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId">The unique identifier assigned during processor&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaymentAppProcessor</returns>
        public VRPayment.Client.ApiResponse<PaymentAppProcessor> PostPaymentWebAppsProcessorsExternalIdActivateForProductionWithHttpInfo(string externalId, long space, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            // verify the required parameter 'externalId' is set
            if (externalId == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'externalId' when calling PaymentWebAppsService->PostPaymentWebAppsProcessorsExternalIdActivateForProduction");
            }

            VRPayment.Client.RequestOptions localVarRequestOptions = new VRPayment.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.PathParameters.Add("externalId", VRPayment.Client.ClientUtils.ParameterToString(externalId)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "PaymentWebAppsService.PostPaymentWebAppsProcessorsExternalIdActivateForProduction";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Post<PaymentAppProcessor>("/payment/web-apps/processors/{externalId}/activate-for-production",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostPaymentWebAppsProcessorsExternalIdActivateForProduction", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Create a connector 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId">The unique identifier assigned during processor&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppConnectorDetailsCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaymentAppConnector</returns>
        public PaymentAppConnector PostPaymentWebAppsProcessorsExternalIdConnectors(string externalId, long space, PaymentAppConnectorDetailsCreate paymentAppConnectorDetailsCreate, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<PaymentAppConnector> localVarResponse = PostPaymentWebAppsProcessorsExternalIdConnectorsWithHttpInfo(externalId, space, paymentAppConnectorDetailsCreate, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a connector 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalId">The unique identifier assigned during processor&#39;s creation.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="paymentAppConnectorDetailsCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaymentAppConnector</returns>
        public VRPayment.Client.ApiResponse<PaymentAppConnector> PostPaymentWebAppsProcessorsExternalIdConnectorsWithHttpInfo(string externalId, long space, PaymentAppConnectorDetailsCreate paymentAppConnectorDetailsCreate, List<string>? expand = default(List<string>?), int operationIndex = 0)
        {
            // verify the required parameter 'externalId' is set
            if (externalId == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'externalId' when calling PaymentWebAppsService->PostPaymentWebAppsProcessorsExternalIdConnectors");
            }

            // verify the required parameter 'paymentAppConnectorDetailsCreate' is set
            if (paymentAppConnectorDetailsCreate == null)
            {
                throw new VRPayment.Client.ApiException(400, "Missing required parameter 'paymentAppConnectorDetailsCreate' when calling PaymentWebAppsService->PostPaymentWebAppsProcessorsExternalIdConnectors");
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

            localVarRequestOptions.PathParameters.Add("externalId", VRPayment.Client.ClientUtils.ParameterToString(externalId)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = paymentAppConnectorDetailsCreate;

            localVarRequestOptions.Operation = "PaymentWebAppsService.PostPaymentWebAppsProcessorsExternalIdConnectors";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Post<PaymentAppConnector>("/payment/web-apps/processors/{externalId}/connectors",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostPaymentWebAppsProcessorsExternalIdConnectors", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
