// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The power state (On | Off) of the node. </summary>
    public readonly partial struct HybridAksClusterMachinePowerState : IEquatable<HybridAksClusterMachinePowerState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HybridAksClusterMachinePowerState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HybridAksClusterMachinePowerState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnValue = "On";
        private const string OffValue = "Off";

        /// <summary> On. </summary>
        public static HybridAksClusterMachinePowerState On { get; } = new HybridAksClusterMachinePowerState(OnValue);
        /// <summary> Off. </summary>
        public static HybridAksClusterMachinePowerState Off { get; } = new HybridAksClusterMachinePowerState(OffValue);
        /// <summary> Determines if two <see cref="HybridAksClusterMachinePowerState"/> values are the same. </summary>
        public static bool operator ==(HybridAksClusterMachinePowerState left, HybridAksClusterMachinePowerState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HybridAksClusterMachinePowerState"/> values are not the same. </summary>
        public static bool operator !=(HybridAksClusterMachinePowerState left, HybridAksClusterMachinePowerState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HybridAksClusterMachinePowerState"/>. </summary>
        public static implicit operator HybridAksClusterMachinePowerState(string value) => new HybridAksClusterMachinePowerState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HybridAksClusterMachinePowerState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HybridAksClusterMachinePowerState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
