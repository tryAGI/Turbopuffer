#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// The current status of a copy operation.
    /// </summary>
    public readonly partial struct CopyFromNamespaceOperation : global::System.IEquatable<CopyFromNamespaceOperation>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceOperationDiscriminatorStatus? Status { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.CopyFromNamespaceOperationRunning? Running { get; init; }
#else
        public global::Turbopuffer.CopyFromNamespaceOperationRunning? Running { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Running))]
#endif
        public bool IsRunning => Running != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRunning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Turbopuffer.CopyFromNamespaceOperationRunning? value)
        {
            value = Running;
            return IsRunning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceOperationRunning PickRunning() => Running is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Running' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Turbopuffer.CopyFromNamespaceOperationFinished? Finished { get; init; }
#else
        public global::Turbopuffer.CopyFromNamespaceOperationFinished? Finished { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Finished))]
#endif
        public bool IsFinished => Finished != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFinished(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Turbopuffer.CopyFromNamespaceOperationFinished? value)
        {
            value = Finished;
            return IsFinished;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Turbopuffer.CopyFromNamespaceOperationFinished PickFinished() => Finished is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Finished' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CopyFromNamespaceOperation(global::Turbopuffer.CopyFromNamespaceOperationRunning value) => new CopyFromNamespaceOperation((global::Turbopuffer.CopyFromNamespaceOperationRunning?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.CopyFromNamespaceOperationRunning?(CopyFromNamespaceOperation @this) => @this.Running;

        /// <summary>
        ///
        /// </summary>
        public CopyFromNamespaceOperation(global::Turbopuffer.CopyFromNamespaceOperationRunning? value)
        {
            Running = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CopyFromNamespaceOperation FromRunning(global::Turbopuffer.CopyFromNamespaceOperationRunning? value) => new CopyFromNamespaceOperation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CopyFromNamespaceOperation(global::Turbopuffer.CopyFromNamespaceOperationFinished value) => new CopyFromNamespaceOperation((global::Turbopuffer.CopyFromNamespaceOperationFinished?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Turbopuffer.CopyFromNamespaceOperationFinished?(CopyFromNamespaceOperation @this) => @this.Finished;

        /// <summary>
        ///
        /// </summary>
        public CopyFromNamespaceOperation(global::Turbopuffer.CopyFromNamespaceOperationFinished? value)
        {
            Finished = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CopyFromNamespaceOperation FromFinished(global::Turbopuffer.CopyFromNamespaceOperationFinished? value) => new CopyFromNamespaceOperation(value);

        /// <summary>
        ///
        /// </summary>
        public CopyFromNamespaceOperation(
            global::Turbopuffer.CopyFromNamespaceOperationDiscriminatorStatus? status,
            global::Turbopuffer.CopyFromNamespaceOperationRunning? running,
            global::Turbopuffer.CopyFromNamespaceOperationFinished? finished
            )
        {
            Status = status;

            Running = running;
            Finished = finished;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Finished as object ??
            Running as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Running?.ToString() ??
            Finished?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRunning && !IsFinished || !IsRunning && IsFinished;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Turbopuffer.CopyFromNamespaceOperationRunning, TResult>? running = null,
            global::System.Func<global::Turbopuffer.CopyFromNamespaceOperationFinished, TResult>? finished = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Running is { } __value0 && running != null)
            {
                return running(__value0);
            }
            else if (Finished is { } __value1 && finished != null)
            {
                return finished(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Turbopuffer.CopyFromNamespaceOperationRunning>? running = null,

            global::System.Action<global::Turbopuffer.CopyFromNamespaceOperationFinished>? finished = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Running is { } __value0)
            {
                running?.Invoke(__value0);
            }
            else if (Finished is { } __value1)
            {
                finished?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Turbopuffer.CopyFromNamespaceOperationRunning>? running = null,
            global::System.Action<global::Turbopuffer.CopyFromNamespaceOperationFinished>? finished = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Running is { } __value0)
            {
                running?.Invoke(__value0);
            }
            else if (Finished is { } __value1)
            {
                finished?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Running,
                typeof(global::Turbopuffer.CopyFromNamespaceOperationRunning),
                Finished,
                typeof(global::Turbopuffer.CopyFromNamespaceOperationFinished),
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
        public bool Equals(CopyFromNamespaceOperation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.CopyFromNamespaceOperationRunning?>.Default.Equals(Running, other.Running) &&
                global::System.Collections.Generic.EqualityComparer<global::Turbopuffer.CopyFromNamespaceOperationFinished?>.Default.Equals(Finished, other.Finished)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CopyFromNamespaceOperation obj1, CopyFromNamespaceOperation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CopyFromNamespaceOperation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CopyFromNamespaceOperation obj1, CopyFromNamespaceOperation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CopyFromNamespaceOperation o && Equals(o);
        }
    }
}
