
#nullable enable

namespace Turbopuffer
{
    /// <summary>
    /// Encrypt the namespace with a customer-managed encryption key (CMEK).
    /// </summary>
    public sealed partial class EncryptionCustomerManaged
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"customer-managed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string Mode { get; set; } = "customer-managed";

        /// <summary>
        /// The identifier of the CMEK key to use for encryption. For GCP, the fully-qualified resource name of the key. For AWS, the ARN of the key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionCustomerManaged" /> class.
        /// </summary>
        /// <param name="keyName">
        /// The identifier of the CMEK key to use for encryption. For GCP, the fully-qualified resource name of the key. For AWS, the ARN of the key.
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EncryptionCustomerManaged(
            string keyName,
            string mode = "customer-managed")
        {
            this.Mode = mode;
            this.KeyName = keyName ?? throw new global::System.ArgumentNullException(nameof(keyName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionCustomerManaged" /> class.
        /// </summary>
        public EncryptionCustomerManaged()
        {
        }

        /// <summary>
        /// Creates a new <see cref="EncryptionCustomerManaged"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static EncryptionCustomerManaged FromKeyName(string keyName)
        {
            return new EncryptionCustomerManaged
            {
                KeyName = keyName,
            };
        }

    }
}