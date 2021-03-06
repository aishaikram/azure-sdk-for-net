// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Results of network configuration diagnostic on the target resource. </summary>
    public partial class NetworkConfigurationDiagnosticResponse
    {
        /// <summary> Initializes a new instance of NetworkConfigurationDiagnosticResponse. </summary>
        internal NetworkConfigurationDiagnosticResponse()
        {
        }

        /// <summary> Initializes a new instance of NetworkConfigurationDiagnosticResponse. </summary>
        /// <param name="results"> List of network configuration diagnostic results. </param>
        internal NetworkConfigurationDiagnosticResponse(IReadOnlyList<NetworkConfigurationDiagnosticResult> results)
        {
            Results = results;
        }

        /// <summary> List of network configuration diagnostic results. </summary>
        public IReadOnlyList<NetworkConfigurationDiagnosticResult> Results { get; }
    }
}
