// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer
{
    /// <summary> The state of the call connection. </summary>
    public readonly partial struct CallConnectionStateModel : IEquatable<CallConnectionStateModel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CallConnectionStateModel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CallConnectionStateModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "unknown";
        private const string ConnectingValue = "connecting";
        private const string ConnectedValue = "connected";
        private const string TransferringValue = "transferring";
        private const string TransferAcceptedValue = "transferAccepted";
        private const string DisconnectingValue = "disconnecting";
        private const string DisconnectedValue = "disconnected";

        /// <summary> unknown. </summary>
        public static CallConnectionStateModel Unknown { get; } = new CallConnectionStateModel(UnknownValue);
        /// <summary> connecting. </summary>
        public static CallConnectionStateModel Connecting { get; } = new CallConnectionStateModel(ConnectingValue);
        /// <summary> connected. </summary>
        public static CallConnectionStateModel Connected { get; } = new CallConnectionStateModel(ConnectedValue);
        /// <summary> transferring. </summary>
        public static CallConnectionStateModel Transferring { get; } = new CallConnectionStateModel(TransferringValue);
        /// <summary> transferAccepted. </summary>
        public static CallConnectionStateModel TransferAccepted { get; } = new CallConnectionStateModel(TransferAcceptedValue);
        /// <summary> disconnecting. </summary>
        public static CallConnectionStateModel Disconnecting { get; } = new CallConnectionStateModel(DisconnectingValue);
        /// <summary> disconnected. </summary>
        public static CallConnectionStateModel Disconnected { get; } = new CallConnectionStateModel(DisconnectedValue);
        /// <summary> Determines if two <see cref="CallConnectionStateModel"/> values are the same. </summary>
        public static bool operator ==(CallConnectionStateModel left, CallConnectionStateModel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CallConnectionStateModel"/> values are not the same. </summary>
        public static bool operator !=(CallConnectionStateModel left, CallConnectionStateModel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CallConnectionStateModel"/>. </summary>
        public static implicit operator CallConnectionStateModel(string value) => new CallConnectionStateModel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CallConnectionStateModel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CallConnectionStateModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
