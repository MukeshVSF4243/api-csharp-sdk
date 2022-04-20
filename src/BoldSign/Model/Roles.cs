/* 
 * BoldSign API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace BoldSign.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    ///     Return roles details for a particular document or template.
    /// </summary>
    [DataContract]
    public class Roles
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Roles" /> class.
        /// </summary>
        /// <param name="roleIndex">Gets or sets the roleIndex..</param>
        /// <param name="signerName">Gets or sets the signerName..</param>
        /// <param name="signerEmail">Gets or sets the signerEmail..</param>
        /// <param name="signerOrder">Gets or sets the signer order..</param>
        /// <param name="signerRole">Gets or sets the role..</param>
        /// <param name="privateMessage">Gets or sets the private message..</param>
        /// <param name="authenticationCode">Gets or sets the authentication code..</param>
        /// <param name="enableEmailOTP">Gets or sets a value indicating whether to enable email OTP.  &lt;br&gt;Email OTP takes higher precedence over AuthenticationCode..</param>
        /// <param name="signerType">signerType.</param>
        /// <param name="formFields">Gets or sets document Form fields such as Sign, Checkbox, Radio buttons etc..</param>
        /// <param name="existingFormFields">Gets or sets value for the existing Form fields..</param>
        /// <param name="language">Gets or sets the Language.</param>
        public Roles(int roleIndex = default, string signerName = default, string signerEmail = default, int signerOrder = default(int), string signerRole = default, string privateMessage = default, string authenticationCode = default, SignerType? signerType = default, bool enableEmailOTP = default, List<FormField> formFields = default(List<FormField>), List<ExistingFormField> existingFormFields = default(List<ExistingFormField>), Languages language = Languages.English)
        {
            this.SignerName = signerName;
            this.SignerEmail = signerEmail;
            this.SignerOrder = SignerOrder;
            this.RoleIndex = roleIndex;
            this.SignerName = signerName;
            this.SignerEmail = signerEmail;
            this.SignerRole = signerRole;
            this.PrivateMessage = privateMessage;
            this.AuthenticationCode = authenticationCode;
            this.EnableEmailOTP = enableEmailOTP;
            this.SignerType = signerType;
            this.FormFields = formFields;
            this.ExistingFormFields = existingFormFields;
            this.Language = language;
        }

        /// <summary>
        ///     Gets or sets the role index of the signer.
        /// </summary>
        /// <value>Gets or sets the roleIndex.</value>
        [DataMember(Name = "roleIndex", EmitDefaultValue = false)]
        public int RoleIndex { get; set; }

        /// <summary>
        ///     Gets or sets the signer name.
        /// </summary>
        /// <value>Gets or sets the signerName.</value>
        [DataMember(Name = "signerName", EmitDefaultValue = true)]
        public string SignerName { get; set; }

        /// <summary>
        ///     Gets or sets the signer email address.
        /// </summary>
        /// <value>Gets or sets the signerEmail.</value>
        [DataMember(Name = "signerEmail", EmitDefaultValue = true)]
        public string SignerEmail { get; set; }

        /// <summary>
        /// Gets or sets the signer order.
        /// </summary>
        /// <value>Gets or sets the signer order.</value>
        [DataMember(Name = "signerOrder", EmitDefaultValue = false)]
        public int? SignerOrder { get; set; }

        /// <summary>
        ///     Gets or sets the private message.
        /// </summary>
        /// <value>Gets or sets the signerEmail.</value>
        [DataMember(Name = "privateMessage", EmitDefaultValue = true)]
        public string PrivateMessage { get; set; }

        /// <summary>
        ///     Gets or sets the authentication code.
        /// </summary>
        /// <value>Gets or sets the signerEmail.</value>
        [DataMember(Name = "authenticationCode", EmitDefaultValue = true)]
        public string AuthenticationCode { get; set; }

        /// <summary>
        ///     Gets or sets the signer type.
        /// </summary>
        /// <value>Gets or sets the signerEmail.</value>
        [DataMember(Name = "signerType", EmitDefaultValue = true)]
        public SignerType? SignerType { get; set; }

        /// <summary>
        ///    Gets or sets a value indicating whether to enable email OTP for signing.
        /// </summary>
        /// <value>Gets or sets the signerEmail.</value>
        [DataMember(Name = "enableEmailOTP", EmitDefaultValue = true)]
        public bool EnableEmailOTP { get; set; }

        /// <summary>
        ///    Gets or sets the signer role in the document.
        /// </summary>
        /// <value>Gets or sets the role.</value>
        [DataMember(Name = "signerRole", EmitDefaultValue = true)]
        public string SignerRole { get; set; }

        /// <summary>
        ///  Gets or sets form fields assigned to signer.
        /// </summary>
        /// <value>Gets or sets document Form fields such as Sign, Checkbox, Radio buttons etc.</value>
        [DataMember(Name = "formFields", EmitDefaultValue = false)]
        public List<FormField> FormFields { get; set; }

        /// <summary>
        /// Gets or sets value for the existing Form fields.
        /// </summary>
        /// <value>Gets or sets value for the existing Form fields.</value>
        [DataMember(Name = "existingFormFields", EmitDefaultValue = false)]
        public List<ExistingFormField> ExistingFormFields { get; set; }

        /// <summary>
        /// Gets or sets the signer language.
        /// </summary>
        /// <value>Gets or sets the language of the signer.</value>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public Languages Language { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
