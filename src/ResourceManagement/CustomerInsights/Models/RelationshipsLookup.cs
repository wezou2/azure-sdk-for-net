// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Azure.Management.CustomerInsights.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The definition of suggested relationship for the type.
    /// </summary>
    public partial class RelationshipsLookup
    {
        /// <summary>
        /// Initializes a new instance of the RelationshipsLookup class.
        /// </summary>
        public RelationshipsLookup()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RelationshipsLookup class.
        /// </summary>
        /// <param name="profileName">The relationship profile.</param>
        /// <param name="profilePropertyReferences">The property references for
        /// the profile type.</param>
        /// <param name="relatedProfileName">The related profile.</param>
        /// <param name="relatedProfilePropertyReferences">The property
        /// references for the related profile type.</param>
        /// <param name="existingRelationshipName">The name of existing
        /// Relationship.</param>
        public RelationshipsLookup(string profileName = default(string), IList<ParticipantProfilePropertyReference> profilePropertyReferences = default(IList<ParticipantProfilePropertyReference>), string relatedProfileName = default(string), IList<ParticipantProfilePropertyReference> relatedProfilePropertyReferences = default(IList<ParticipantProfilePropertyReference>), string existingRelationshipName = default(string))
        {
            ProfileName = profileName;
            ProfilePropertyReferences = profilePropertyReferences;
            RelatedProfileName = relatedProfileName;
            RelatedProfilePropertyReferences = relatedProfilePropertyReferences;
            ExistingRelationshipName = existingRelationshipName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the relationship profile.
        /// </summary>
        [JsonProperty(PropertyName = "profileName")]
        public string ProfileName { get; private set; }

        /// <summary>
        /// Gets the property references for the profile type.
        /// </summary>
        [JsonProperty(PropertyName = "profilePropertyReferences")]
        public IList<ParticipantProfilePropertyReference> ProfilePropertyReferences { get; private set; }

        /// <summary>
        /// Gets the related profile.
        /// </summary>
        [JsonProperty(PropertyName = "relatedProfileName")]
        public string RelatedProfileName { get; private set; }

        /// <summary>
        /// Gets the property references for the related profile type.
        /// </summary>
        [JsonProperty(PropertyName = "relatedProfilePropertyReferences")]
        public IList<ParticipantProfilePropertyReference> RelatedProfilePropertyReferences { get; private set; }

        /// <summary>
        /// Gets the name of existing Relationship.
        /// </summary>
        [JsonProperty(PropertyName = "existingRelationshipName")]
        public string ExistingRelationshipName { get; private set; }

    }
}