// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped encryption key will be used. &apos;Service&apos; key type implies that a default service key is used. </summary>
    public readonly partial struct StorageKeyType : IEquatable<StorageKeyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageKeyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServiceValue = "Service";
        private const string AccountValue = "Account";

        /// <summary> Service. </summary>
        public static StorageKeyType Service { get; } = new StorageKeyType(ServiceValue);
        /// <summary> Account. </summary>
        public static StorageKeyType Account { get; } = new StorageKeyType(AccountValue);
        /// <summary> Determines if two <see cref="StorageKeyType"/> values are the same. </summary>
        public static bool operator ==(StorageKeyType left, StorageKeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageKeyType"/> values are not the same. </summary>
        public static bool operator !=(StorageKeyType left, StorageKeyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StorageKeyType"/>. </summary>
        public static implicit operator StorageKeyType(string value) => new StorageKeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageKeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageKeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
