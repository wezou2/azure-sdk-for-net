// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of available countries with details.
    /// </summary>
    public partial class AvailableProvidersList
    {
        /// <summary>
        /// Initializes a new instance of the AvailableProvidersList class.
        /// </summary>
        public AvailableProvidersList()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableProvidersList class.
        /// </summary>
        /// <param name="countries">List of available countries.</param>
        public AvailableProvidersList(IList<AvailableProvidersListCountry> countries)
        {
            Countries = countries;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of available countries.
        /// </summary>
        [JsonProperty(PropertyName = "countries")]
        public IList<AvailableProvidersListCountry> Countries { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Countries == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Countries");
            }
        }
    }
}
