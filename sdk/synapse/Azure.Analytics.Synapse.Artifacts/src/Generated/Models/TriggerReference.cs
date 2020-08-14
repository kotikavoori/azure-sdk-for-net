// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Trigger reference type. </summary>
    public partial class TriggerReference
    {
        /// <summary> Initializes a new instance of TriggerReference. </summary>
        /// <param name="type"> Trigger reference type. </param>
        /// <param name="referenceName"> Reference trigger name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public TriggerReference(TriggerReferenceType type, string referenceName)
        {
            if (referenceName == null)
            {
                throw new ArgumentNullException(nameof(referenceName));
            }

            Type = type;
            ReferenceName = referenceName;
        }

        /// <summary> Trigger reference type. </summary>
        public TriggerReferenceType Type { get; set; }
        /// <summary> Reference trigger name. </summary>
        public string ReferenceName { get; set; }
    }
}
