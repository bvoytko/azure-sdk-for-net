// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Quantum.Models
{
    /// <summary> Result of check name availability. </summary>
    public partial class CheckNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of CheckNameAvailabilityResult. </summary>
        internal CheckNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of CheckNameAvailabilityResult. </summary>
        /// <param name="nameAvailable"> Indicator of availability of the Quantum Workspace resource name. </param>
        /// <param name="reason"> The reason of unavailability. </param>
        /// <param name="message"> The detailed info regarding the reason associated with the Namespace. </param>
        internal CheckNameAvailabilityResult(bool? nameAvailable, string reason, string message)
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary> Indicator of availability of the Quantum Workspace resource name. </summary>
        public bool? NameAvailable { get; }
        /// <summary> The reason of unavailability. </summary>
        public string Reason { get; }
        /// <summary> The detailed info regarding the reason associated with the Namespace. </summary>
        public string Message { get; }
    }
}
