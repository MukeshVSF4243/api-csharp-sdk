// <copyright file="DocumentInfo.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    ///    The document information include the language, document title and document description.
    /// </summary>
    [DataContract]
    public class DocumentInfo
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DocumentInfo" /> class.
        /// </summary>
        /// <param name="language">Gets or sets the language.</param>
        /// <param name="title">Gets or sets the title.</param>
        /// <param name="description">Gets or sets the descriptiondescription.</param>
        [Obsolete("The language-based constructor is deprecated. Please use the new constructor: DocumentInfo(string documentTitle, string documentDescription = default)")]
        public DocumentInfo(Languages language = Languages.None, string title = default, string description = default)
        {
            this.Language = language;
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentInfo" /> class.
        /// </summary>
        /// <param name="documentTitle">Gets or sets the documentTitle.(required).</param>
        /// <param name="documentDescription">Gets or sets the documentDescription.</param>
        /// <param name="locale">Gets or sets the locale.</param>
        public DocumentInfo(string documentTitle, string documentDescription = default, Locales locale = Locales.EN)
        {
            this.Title = documentTitle;
            this.Description = documentDescription;
            this.Locale = locale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentInfo" /> class.
        /// </summary>
        public DocumentInfo()
        {

        }

        /// <summary>
        ///  Gets or sets the language of the document.
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        [Obsolete("Language is deprecated, please use Locale instead.")]
        public Languages Language { get; set; }

        /// <summary>
        /// Gets or sets locale such as EN, FR, ES.
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = true)]
        public Locales Locale { get; set; }

        /// <summary>
        ///     Gets or sets the title.
        /// </summary>
        /// <value>Gets or sets the Title.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        ///  Gets or sets the description.
        /// </summary>
        /// <value>Gets or sets the Description.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
