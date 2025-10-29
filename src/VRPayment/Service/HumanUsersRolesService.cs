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
    public interface IHumanUsersRolesServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Unassign a role from a human user for an account
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteHumanUsersUserIdAccountRoles(long userId, long roleId, long account, int operationIndex = 0);

        /// <summary>
        /// Unassign a role from a human user for an account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteHumanUsersUserIdAccountRolesWithHttpInfo(long userId, long roleId, long account, int operationIndex = 0);

        /// <summary>
        /// Unassign a role from a human user for a space
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteHumanUsersUserIdSpaceRoles(long userId, long roleId, long space, int operationIndex = 0);

        /// <summary>
        /// Unassign a role from a human user for a space
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteHumanUsersUserIdSpaceRolesWithHttpInfo(long userId, long roleId, long space, int operationIndex = 0);

        /// <summary>
        /// List all roles of a human user for an account
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserAccountRoleListResponse</returns>
        UserAccountRoleListResponse GetHumanUsersUserIdAccountRoles(long userId, long account, int operationIndex = 0);

        /// <summary>
        /// List all roles of a human user for an account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserAccountRoleListResponse</returns>
        ApiResponse<UserAccountRoleListResponse> GetHumanUsersUserIdAccountRolesWithHttpInfo(long userId, long account, int operationIndex = 0);

        /// <summary>
        /// List all roles of a human user for a space
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserSpaceRoleListResponse</returns>
        UserSpaceRoleListResponse GetHumanUsersUserIdSpaceRoles(long userId, long space, int operationIndex = 0);

        /// <summary>
        /// List all roles of a human user for a space
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserSpaceRoleListResponse</returns>
        ApiResponse<UserSpaceRoleListResponse> GetHumanUsersUserIdSpaceRolesWithHttpInfo(long userId, long space, int operationIndex = 0);

        /// <summary>
        /// Assign a role to a human user for an account
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="appliesOnSubAccount">Whether the role should be assigned to the user in subaccounts only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserAccountRole</returns>
        UserAccountRole PostHumanUsersUserIdAccountRoles(long userId, long roleId, long account, bool? appliesOnSubAccount = default(bool?), int operationIndex = 0);

        /// <summary>
        /// Assign a role to a human user for an account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="appliesOnSubAccount">Whether the role should be assigned to the user in subaccounts only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserAccountRole</returns>
        ApiResponse<UserAccountRole> PostHumanUsersUserIdAccountRolesWithHttpInfo(long userId, long roleId, long account, bool? appliesOnSubAccount = default(bool?), int operationIndex = 0);

        /// <summary>
        /// Assign a role to a human user for a space
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserSpaceRole</returns>
        UserSpaceRole PostHumanUsersUserIdSpaceRoles(long userId, long roleId, long space, int operationIndex = 0);

        /// <summary>
        /// Assign a role to a human user for a space
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserSpaceRole</returns>
        ApiResponse<UserSpaceRole> PostHumanUsersUserIdSpaceRolesWithHttpInfo(long userId, long roleId, long space, int operationIndex = 0);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHumanUsersRolesService : IHumanUsersRolesServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class HumanUsersRolesService : IHumanUsersRolesService
    {

        private VRPayment.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanUsersRolesService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public HumanUsersRolesService(VRPayment.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new VRPayment.Client.ApiClient(this.Configuration);
            ExceptionFactory = VRPayment.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanUsersRolesService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public HumanUsersRolesService(VRPayment.Client.ISynchronousClient client, VRPayment.Client.IReadableConfiguration configuration)
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
        /// Unassign a role from a human user for an account 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteHumanUsersUserIdAccountRoles(long userId, long roleId, long account, int operationIndex = 0)
        {
            DeleteHumanUsersUserIdAccountRolesWithHttpInfo(userId, roleId, account);
        }

        /// <summary>
        /// Unassign a role from a human user for an account 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public VRPayment.Client.ApiResponse<Object> DeleteHumanUsersUserIdAccountRolesWithHttpInfo(long userId, long roleId, long account, int operationIndex = 0)
        {
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

            localVarRequestOptions.PathParameters.Add("userId", VRPayment.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("", "roleId", roleId));
            localVarRequestOptions.HeaderParameters.Add("Account", VRPayment.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "HumanUsersRolesService.DeleteHumanUsersUserIdAccountRoles";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/human-users/{userId}/account-roles",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteHumanUsersUserIdAccountRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Unassign a role from a human user for a space 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteHumanUsersUserIdSpaceRoles(long userId, long roleId, long space, int operationIndex = 0)
        {
            DeleteHumanUsersUserIdSpaceRolesWithHttpInfo(userId, roleId, space);
        }

        /// <summary>
        /// Unassign a role from a human user for a space 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public VRPayment.Client.ApiResponse<Object> DeleteHumanUsersUserIdSpaceRolesWithHttpInfo(long userId, long roleId, long space, int operationIndex = 0)
        {
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

            localVarRequestOptions.PathParameters.Add("userId", VRPayment.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("", "roleId", roleId));
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "HumanUsersRolesService.DeleteHumanUsersUserIdSpaceRoles";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/human-users/{userId}/space-roles",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteHumanUsersUserIdSpaceRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// List all roles of a human user for an account 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserAccountRoleListResponse</returns>
        public UserAccountRoleListResponse GetHumanUsersUserIdAccountRoles(long userId, long account, int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<UserAccountRoleListResponse> localVarResponse = GetHumanUsersUserIdAccountRolesWithHttpInfo(userId, account);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all roles of a human user for an account 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserAccountRoleListResponse</returns>
        public VRPayment.Client.ApiResponse<UserAccountRoleListResponse> GetHumanUsersUserIdAccountRolesWithHttpInfo(long userId, long account, int operationIndex = 0)
        {
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

            localVarRequestOptions.PathParameters.Add("userId", VRPayment.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Account", VRPayment.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "HumanUsersRolesService.GetHumanUsersUserIdAccountRoles";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Get<UserAccountRoleListResponse>("/human-users/{userId}/account-roles",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetHumanUsersUserIdAccountRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// List all roles of a human user for a space 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserSpaceRoleListResponse</returns>
        public UserSpaceRoleListResponse GetHumanUsersUserIdSpaceRoles(long userId, long space, int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<UserSpaceRoleListResponse> localVarResponse = GetHumanUsersUserIdSpaceRolesWithHttpInfo(userId, space);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all roles of a human user for a space 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserSpaceRoleListResponse</returns>
        public VRPayment.Client.ApiResponse<UserSpaceRoleListResponse> GetHumanUsersUserIdSpaceRolesWithHttpInfo(long userId, long space, int operationIndex = 0)
        {
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

            localVarRequestOptions.PathParameters.Add("userId", VRPayment.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "HumanUsersRolesService.GetHumanUsersUserIdSpaceRoles";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Get<UserSpaceRoleListResponse>("/human-users/{userId}/space-roles",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetHumanUsersUserIdSpaceRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Assign a role to a human user for an account 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="appliesOnSubAccount">Whether the role should be assigned to the user in subaccounts only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserAccountRole</returns>
        public UserAccountRole PostHumanUsersUserIdAccountRoles(long userId, long roleId, long account, bool? appliesOnSubAccount = default(bool?), int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<UserAccountRole> localVarResponse = PostHumanUsersUserIdAccountRolesWithHttpInfo(userId, roleId, account, appliesOnSubAccount);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Assign a role to a human user for an account 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="appliesOnSubAccount">Whether the role should be assigned to the user in subaccounts only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserAccountRole</returns>
        public VRPayment.Client.ApiResponse<UserAccountRole> PostHumanUsersUserIdAccountRolesWithHttpInfo(long userId, long roleId, long account, bool? appliesOnSubAccount = default(bool?), int operationIndex = 0)
        {
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

            localVarRequestOptions.PathParameters.Add("userId", VRPayment.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("", "roleId", roleId));
            if (appliesOnSubAccount != null)
            {
                localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("", "appliesOnSubAccount", appliesOnSubAccount));
            }
            localVarRequestOptions.HeaderParameters.Add("Account", VRPayment.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "HumanUsersRolesService.PostHumanUsersUserIdAccountRoles";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Post<UserAccountRole>("/human-users/{userId}/account-roles",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostHumanUsersUserIdAccountRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Assign a role to a human user for a space 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserSpaceRole</returns>
        public UserSpaceRole PostHumanUsersUserIdSpaceRoles(long userId, long roleId, long space, int operationIndex = 0)
        {
            VRPayment.Client.ApiResponse<UserSpaceRole> localVarResponse = PostHumanUsersUserIdSpaceRolesWithHttpInfo(userId, roleId, space);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Assign a role to a human user for a space 
        /// </summary>
        /// <exception cref="VRPayment.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserSpaceRole</returns>
        public VRPayment.Client.ApiResponse<UserSpaceRole> PostHumanUsersUserIdSpaceRolesWithHttpInfo(long userId, long roleId, long space, int operationIndex = 0)
        {
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

            localVarRequestOptions.PathParameters.Add("userId", VRPayment.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(VRPayment.Client.ClientUtils.ParameterToMultiMap("", "roleId", roleId));
            localVarRequestOptions.HeaderParameters.Add("Space", VRPayment.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "HumanUsersRolesService.PostHumanUsersUserIdSpaceRoles";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Post<UserSpaceRole>("/human-users/{userId}/space-roles",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostHumanUsersUserIdSpaceRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
