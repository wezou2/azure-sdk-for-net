// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The properties of a routing rule that your IoT hub uses to route
    /// messages to endpoints.
    /// </summary>
    public partial class RouteProperties
    {
        /// <summary>
        /// Initializes a new instance of the RouteProperties class.
        /// </summary>
        public RouteProperties() { }

        /// <summary>
        /// Initializes a new instance of the RouteProperties class.
        /// </summary>
        /// <param name="name">The name of the route. The name can only include alphanumeric characters, periods, underscores, hyphens, has a maximum length of 64 characters,  and must be unique.</param>
        /// <param name="source">The source that the routing rule is to be applied to, such as DeviceMessages. Possible values include: 'DeviceMessages', 'TwinChangeEvents', 'DeviceLifecycleEvents', 'DeviceJobLifecycleEvents'</param>
        /// <param name="endpointNames">The list of endpoints to which messages that satisfy the condition are routed. Currently only one endpoint is allowed.</param>
        /// <param name="isEnabled">Used to specify whether a route is enabled.</param>
        /// <param name="condition">The condition that is evaluated to apply the routing rule. If no condition is provided, it evaluates to true by default. For grammar, See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language</param>
        public RouteProperties(string name, string source, IList<string> endpointNames, bool isEnabled, string condition = default(string))
        {
            Name = name;
            Source = source;
            Condition = condition;
            EndpointNames = endpointNames;
            IsEnabled = isEnabled;
        }

        /// <summary>
        /// Gets or sets the name of the route. The name can only include
        /// alphanumeric characters, periods, underscores, hyphens, has a
        /// maximum length of 64 characters,  and must be unique.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the source that the routing rule is to be applied to,
        /// such as DeviceMessages. Possible values include:
        /// 'DeviceMessages', 'TwinChangeEvents', 'DeviceLifecycleEvents',
        /// 'DeviceJobLifecycleEvents'
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the condition that is evaluated to apply the routing
        /// rule. If no condition is provided, it evaluates to true by
        /// default. For grammar, See:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }

        /// <summary>
        /// Gets or sets the list of endpoints to which messages that satisfy
        /// the condition are routed. Currently only one endpoint is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "endpointNames")]
        public IList<string> EndpointNames { get; set; }

        /// <summary>
        /// Gets or sets used to specify whether a route is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (EndpointNames == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EndpointNames");
            }
            if (this.Name != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.Name, "^[A-Za-z0-9-._]{1,64}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[A-Za-z0-9-._]{1,64}$");
                }
            }
            if (this.EndpointNames != null)
            {
                if (this.EndpointNames.Count > 1)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "EndpointNames", 1);
                }
                if (this.EndpointNames.Count < 1)
                {
                    throw new ValidationException(ValidationRules.MinItems, "EndpointNames", 1);
                }
            }
        }
    }
}
