#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// The encryption configuration for a namespace.
    /// </summary>
    public readonly partial struct Encryption : global::System.IEquatable<Encryption>
    {
        /// <summary>
        /// Encrypt the namespace with a customer-managed encryption key (CMEK).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.EncryptionCustomerManaged? CustomerManaged { get; init; }
#else
        public global::Turbopuffer.EncryptionCustomerManaged? CustomerManaged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomerManaged))]
#endif
        public bool IsCustomerManaged => CustomerManaged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomerManaged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Turbopuffer.EncryptionCustomerManaged? value)
        {
            value = CustomerManaged;
            return IsCustomerManaged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.EncryptionCustomerManaged PickCustomerManaged() => CustomerManaged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomerManaged' but the value was {ToString()}.");

        /// <summary>
        /// Use the default server-side encryption (SSE).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.EncryptionDefault? Default { get; init; }
#else
        public global::Turbopuffer.EncryptionDefault? Default { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Default))]
#endif
        public bool IsDefault => Default != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDefault(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Turbopuffer.EncryptionDefault? value)
        {
            value = Default;
            return IsDefault;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.EncryptionDefault PickDefault() => Default is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Default' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Encryption(global::Turbopuffer.EncryptionCustomerManaged value) => new Encryption((global::Turbopuffer.EncryptionCustomerManaged?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.EncryptionCustomerManaged?(Encryption @this) => @this.CustomerManaged;

        /// <summary>
        ///
        /// </summary>
        public Encryption(global::Turbopuffer.EncryptionCustomerManaged? value)
        {
            CustomerManaged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Encryption FromCustomerManaged(global::Turbopuffer.EncryptionCustomerManaged? value) => new Encryption(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Encryption(global::Turbopuffer.EncryptionDefault value) => new Encryption((global::Turbopuffer.EncryptionDefault?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.EncryptionDefault?(Encryption @this) => @this.Default;

        /// <summary>
        ///
        /// </summary>
        public Encryption(global::Turbopuffer.EncryptionDefault? value)
        {
            Default = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Encryption FromDefault(global::Turbopuffer.EncryptionDefault? value) => new Encryption(value);

        /// <summary>
        ///
        /// </summary>
        public Encryption(
            global::Turbopuffer.EncryptionCustomerManaged? customerManaged,
            global::Turbopuffer.EncryptionDefault? @default
            )
        {
            CustomerManaged = customerManaged;
            Default = @default;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Default as object ??
            CustomerManaged as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CustomerManaged?.ToString() ??
            Default?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCustomerManaged && !IsDefault || !IsCustomerManaged && IsDefault;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Turbopuffer.EncryptionCustomerManaged, TResult>? customerManaged = null,
            global::System.Func<global::Turbopuffer.EncryptionDefault, TResult>? @default = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CustomerManaged is { } __value0 && customerManaged != null)
            {
                return customerManaged(__value0);
            }
            else if (Default is { } __value1 && @default != null)
            {
                return @default(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Turbopuffer.EncryptionCustomerManaged>? customerManaged = null,

            global::System.Action<global::Turbopuffer.EncryptionDefault>? @default = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CustomerManaged is { } __value0)
            {
                customerManaged?.Invoke(__value0);
            }
            else if (Default is { } __value1)
            {
                @default?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Turbopuffer.EncryptionCustomerManaged>? customerManaged = null,
            global::System.Action<global::Turbopuffer.EncryptionDefault>? @default = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CustomerManaged is { } __value0)
            {
                customerManaged?.Invoke(__value0);
            }
            else if (Default is { } __value1)
            {
                @default?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CustomerManaged,
                typeof(global::Turbopuffer.EncryptionCustomerManaged),
                Default,
                typeof(global::Turbopuffer.EncryptionDefault),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(Encryption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.EncryptionCustomerManaged?>.Default.Equals(CustomerManaged, other.CustomerManaged) &&
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.EncryptionDefault?>.Default.Equals(Default, other.Default)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Encryption obj1, Encryption obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Encryption>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Encryption obj1, Encryption obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Encryption o && Equals(o);
        }
    }
}
