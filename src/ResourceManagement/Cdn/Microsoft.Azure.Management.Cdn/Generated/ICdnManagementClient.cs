// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Use these APIs to manage Azure CDN resources through the Azure
    /// Resource Manager. You must make sure that requests made to these
    /// resources are secure.
    /// </summary>
    public partial interface ICdnManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        Microsoft.Rest.ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Azure Subscription ID.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Version of the API to be used with the client request. Current
        /// version is 2016-10-02.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is
        /// generated and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IProfilesOperations.
        /// </summary>
        IProfilesOperations Profiles { get; }

        /// <summary>
        /// Gets the IEndpointsOperations.
        /// </summary>
        IEndpointsOperations Endpoints { get; }

        /// <summary>
        /// Gets the IOriginsOperations.
        /// </summary>
        IOriginsOperations Origins { get; }

        /// <summary>
        /// Gets the ICustomDomainsOperations.
        /// </summary>
        ICustomDomainsOperations CustomDomains { get; }

        /// <summary>
        /// Gets the IEdgeNodesOperations.
        /// </summary>
        IEdgeNodesOperations EdgeNodes { get; }

            /// <summary>
        /// Check the availability of a resource name. This is needed for
        /// resources where name is globally unique, such as a CDN endpoint.
        /// </summary>
        /// <param name='name'>
        /// The resource name to validate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<CheckNameAvailabilityOutput>> CheckNameAvailabilityWithHttpMessagesAsync(string name, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Check the quota and actual usage of the CDN profiles under the
        /// given subscription.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<ResourceUsage>>> CheckResourceUsageWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Lists all of the available CDN REST API operations.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<Operation>>> ListOperationsWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Check the quota and actual usage of the CDN profiles under the
        /// given subscription.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<ResourceUsage>>> CheckResourceUsageNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Lists all of the available CDN REST API operations.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<Operation>>> ListOperationsNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}
