// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of Deployment and their operations over its parent. </summary>
    public partial class DeploymentCollection : ArmCollection, IEnumerable<Deployment>, IAsyncEnumerable<Deployment>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DeploymentsRestOperations _deploymentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeploymentCollection"/> class for mocking. </summary>
        protected DeploymentCollection()
        {
        }

        /// <summary> Initializes a new instance of DeploymentCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DeploymentCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _deploymentsRestClient = new DeploymentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.Root.ResourceType;

        /// <summary> Verify that the input resource Id is a valid collection for this type. </summary>
        /// <param name="identifier"> The input resource Id to check. </param>
        protected override void ValidateResourceType(ResourceIdentifier identifier)
        {
        }

        // Collection level operations.

        /// <summary> You can provide the template and parameters directly in the request or link to JSON files. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="parameters"> Additional parameters supplied to the operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DeploymentCreateOrUpdateAtScopeOperation CreateOrUpdate(string deploymentName, DeploymentInput parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deploymentsRestClient.CreateOrUpdateAtScope(Id, deploymentName, parameters, cancellationToken);
                var operation = new DeploymentCreateOrUpdateAtScopeOperation(Parent, _clientDiagnostics, Pipeline, _deploymentsRestClient.CreateCreateOrUpdateAtScopeRequest(Id, deploymentName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> You can provide the template and parameters directly in the request or link to JSON files. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="parameters"> Additional parameters supplied to the operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DeploymentCreateOrUpdateAtScopeOperation> CreateOrUpdateAsync(string deploymentName, DeploymentInput parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deploymentsRestClient.CreateOrUpdateAtScopeAsync(Id, deploymentName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new DeploymentCreateOrUpdateAtScopeOperation(Parent, _clientDiagnostics, Pipeline, _deploymentsRestClient.CreateCreateOrUpdateAtScopeRequest(Id, deploymentName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a deployment. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<Deployment> Get(string deploymentName, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentCollection.Get");
            scope.Start();
            try
            {
                var response = _deploymentsRestClient.GetAtScope(Id, deploymentName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Deployment(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a deployment. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public async virtual Task<Response<Deployment>> GetAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentCollection.Get");
            scope.Start();
            try
            {
                var response = await _deploymentsRestClient.GetAtScopeAsync(Id, deploymentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Deployment(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<Deployment> GetIfExists(string deploymentName, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deploymentsRestClient.GetAtScope(Id, deploymentName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Deployment>(null, response.GetRawResponse())
                    : Response.FromValue(new Deployment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public async virtual Task<Response<Deployment>> GetIfExistsAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _deploymentsRestClient.GetAtScopeAsync(Id, deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Deployment>(null, response.GetRawResponse())
                    : Response.FromValue(new Deployment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<bool> Exists(string deploymentName, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(deploymentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all the deployments at the given scope. </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=provisioningState eq &apos;{state}&apos;. </param>
        /// <param name="top"> The number of results to get. If null is passed, returns all deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Deployment" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Deployment> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<Deployment> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deploymentsRestClient.ListAtScope(Id, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Deployment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Deployment> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deploymentsRestClient.ListAtScopeNextPage(nextLink, Id, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Deployment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get all the deployments at the given scope. </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=provisioningState eq &apos;{state}&apos;. </param>
        /// <param name="top"> The number of results to get. If null is passed, returns all deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Deployment" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Deployment> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Deployment>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deploymentsRestClient.ListAtScopeAsync(Id, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Deployment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Deployment>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deploymentsRestClient.ListAtScopeNextPageAsync(nextLink, Id, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Deployment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<Deployment> IEnumerable<Deployment>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Deployment> IAsyncEnumerable<Deployment>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, Deployment, DeploymentData> Construct() { }
    }
}
