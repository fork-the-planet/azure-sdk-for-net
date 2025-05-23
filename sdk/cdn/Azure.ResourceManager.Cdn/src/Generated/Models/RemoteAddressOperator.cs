// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Describes operator to be matched
    /// Serialized Name: RemoteAddressOperator
    /// </summary>
    public readonly partial struct RemoteAddressOperator : IEquatable<RemoteAddressOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RemoteAddressOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RemoteAddressOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnyValue = "Any";
        private const string IPMatchValue = "IPMatch";
        private const string GeoMatchValue = "GeoMatch";

        /// <summary>
        /// Any
        /// Serialized Name: RemoteAddressOperator.Any
        /// </summary>
        public static RemoteAddressOperator Any { get; } = new RemoteAddressOperator(AnyValue);
        /// <summary>
        /// IPMatch
        /// Serialized Name: RemoteAddressOperator.IPMatch
        /// </summary>
        public static RemoteAddressOperator IPMatch { get; } = new RemoteAddressOperator(IPMatchValue);
        /// <summary>
        /// GeoMatch
        /// Serialized Name: RemoteAddressOperator.GeoMatch
        /// </summary>
        public static RemoteAddressOperator GeoMatch { get; } = new RemoteAddressOperator(GeoMatchValue);
        /// <summary> Determines if two <see cref="RemoteAddressOperator"/> values are the same. </summary>
        public static bool operator ==(RemoteAddressOperator left, RemoteAddressOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RemoteAddressOperator"/> values are not the same. </summary>
        public static bool operator !=(RemoteAddressOperator left, RemoteAddressOperator right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RemoteAddressOperator"/>. </summary>
        public static implicit operator RemoteAddressOperator(string value) => new RemoteAddressOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RemoteAddressOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RemoteAddressOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
