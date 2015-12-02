// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.ExpressRoute;
using Microsoft.WindowsAzure.Management.ExpressRoute.Models;

namespace Microsoft.WindowsAzure.Management.ExpressRoute
{
    internal partial class DedicatedCircuitPeeringRouteTableInfoOperations : IServiceOperations<ExpressRouteManagementClient>, IDedicatedCircuitPeeringRouteTableInfoOperations
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DedicatedCircuitPeeringRouteTableInfoOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal DedicatedCircuitPeeringRouteTableInfoOperations(ExpressRouteManagementClient client)
        {
            this._client = client;
        }
        
        private ExpressRouteManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.ExpressRoute.ExpressRouteManagementClient.
        /// </summary>
        public ExpressRouteManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// The Get DedicatedCircuitPeeringRouteTableInfo operation retrieves
        /// VPNv4 information from the BGP database.
        /// </summary>
        /// <param name='serviceKey'>
        /// Required. The service key representing the circuit.
        /// </param>
        /// <param name='accessType'>
        /// Required. Whether the peering is private or public or microsoft.
        /// </param>
        /// <param name='devicePath'>
        /// Required. Whether the device is primary or secondary.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get DedicatedCircuitPeeringRouteTableInfo operation response.
        /// </returns>
        public async Task<DedicatedCircuitPeeringRouteTableInfoGetResponse> GetAsync(string serviceKey, BgpPeeringAccessType accessType, DevicePath devicePath, CancellationToken cancellationToken)
        {
            // Validate
            if (serviceKey == null)
            {
                throw new ArgumentNullException("serviceKey");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serviceKey", serviceKey);
                tracingParameters.Add("accessType", accessType);
                tracingParameters.Add("devicePath", devicePath);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/services/networking/dedicatedcircuits/";
            url = url + Uri.EscapeDataString(serviceKey);
            url = url + "/bgppeerings/";
            url = url + Uri.EscapeDataString(ExpressRouteManagementClient.BgpPeeringAccessTypeToString(accessType));
            url = url + "/routeTable/";
            url = url + Uri.EscapeDataString(ExpressRouteManagementClient.DevicePathToString(devicePath));
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=1.0");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2011-10-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    DedicatedCircuitPeeringRouteTableInfoGetResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new DedicatedCircuitPeeringRouteTableInfoGetResponse();
                        XDocument responseDoc = XDocument.Parse(responseContent);
                        
                        XElement dedicatedCircuitPeeringRouteTableInfoElement = responseDoc.Element(XName.Get("DedicatedCircuitPeeringRouteTableInfo", "http://schemas.microsoft.com/windowsazure"));
                        if (dedicatedCircuitPeeringRouteTableInfoElement != null)
                        {
                            AzureDedicatedCircuitPeeringRouteTableInfo dedicatedCircuitPeeringRouteTableInfoInstance = new AzureDedicatedCircuitPeeringRouteTableInfo();
                            result.DedicatedCircuitPeeringRouteTableInfo = dedicatedCircuitPeeringRouteTableInfoInstance;
                            
                            XElement networkElement = dedicatedCircuitPeeringRouteTableInfoElement.Element(XName.Get("Network", "http://schemas.microsoft.com/windowsazure"));
                            if (networkElement != null)
                            {
                                string networkInstance = networkElement.Value;
                                dedicatedCircuitPeeringRouteTableInfoInstance.Network = networkInstance;
                            }
                            
                            XElement nextHopElement = dedicatedCircuitPeeringRouteTableInfoElement.Element(XName.Get("NextHop", "http://schemas.microsoft.com/windowsazure"));
                            if (nextHopElement != null)
                            {
                                string nextHopInstance = nextHopElement.Value;
                                dedicatedCircuitPeeringRouteTableInfoInstance.NextHop = nextHopInstance;
                            }
                            
                            XElement locPrfElement = dedicatedCircuitPeeringRouteTableInfoElement.Element(XName.Get("LocPrf", "http://schemas.microsoft.com/windowsazure"));
                            if (locPrfElement != null)
                            {
                                string locPrfInstance = locPrfElement.Value;
                                dedicatedCircuitPeeringRouteTableInfoInstance.LocPrf = locPrfInstance;
                            }
                            
                            XElement weightElement = dedicatedCircuitPeeringRouteTableInfoElement.Element(XName.Get("Weight", "http://schemas.microsoft.com/windowsazure"));
                            if (weightElement != null)
                            {
                                int weightInstance = int.Parse(weightElement.Value, CultureInfo.InvariantCulture);
                                dedicatedCircuitPeeringRouteTableInfoInstance.Weight = weightInstance;
                            }
                            
                            XElement pathElement = dedicatedCircuitPeeringRouteTableInfoElement.Element(XName.Get("Path", "http://schemas.microsoft.com/windowsazure"));
                            if (pathElement != null)
                            {
                                string pathInstance = pathElement.Value;
                                dedicatedCircuitPeeringRouteTableInfoInstance.Path = pathInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
