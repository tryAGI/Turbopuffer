
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    ///
    /// </summary>
    public enum CopyFromNamespaceOperationDiscriminatorStatus
    {
        /// <summary>
        ///
        /// </summary>
        Finished,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopyFromNamespaceOperationDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopyFromNamespaceOperationDiscriminatorStatus value)
        {
            return value switch
            {
                CopyFromNamespaceOperationDiscriminatorStatus.Finished => "finished",
                CopyFromNamespaceOperationDiscriminatorStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopyFromNamespaceOperationDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "finished" => CopyFromNamespaceOperationDiscriminatorStatus.Finished,
                "running" => CopyFromNamespaceOperationDiscriminatorStatus.Running,
                _ => null,
            };
        }
    }
}