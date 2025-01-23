// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal readonly partial struct HyperparameterCycleCount : IEquatable<HyperparameterCycleCount>
    {
        private readonly string _value;
        private const string AutoValue = "auto";

        public HyperparameterCycleCount(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static HyperparameterCycleCount Auto { get; } = new HyperparameterCycleCount(AutoValue);

        public static bool operator ==(HyperparameterCycleCount left, HyperparameterCycleCount right) => left.Equals(right);

        public static bool operator !=(HyperparameterCycleCount left, HyperparameterCycleCount right) => !left.Equals(right);

        public static implicit operator HyperparameterCycleCount(string value) => new HyperparameterCycleCount(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HyperparameterCycleCount other && Equals(other);

        public bool Equals(HyperparameterCycleCount other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
