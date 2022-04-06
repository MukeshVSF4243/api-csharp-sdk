// <copyright file="TextTag.cs" company="Syncfusion Inc">
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

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using BoldSign.Model;
    using Newtonsoft.Json;

    /// <summary>
    /// The text tag model.
    /// </summary>
    public class TextTagDefinition
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TextTagDefinition" /> class.
        /// </summary>
        /// <param name="definitionId">Gets or sets the definitionId. (required).</param>
        /// <param name="type">Gets or sets the type. (required).</param>
        /// <param name="signerIndex">Gets or sets the signerIndex.</param>
        /// <param name="isRequired">Gets or sets the isRequired.</param>
        /// <param name="placeholder">Gets or sets the placeholder for textbox.</param>
        /// <param name="fieldId">Gets or sets a fieldId.</param>
        /// <param name="font">font.</param>
        /// <param name="validation">Gets or sets the validation.</param>
        /// <param name="size">Gets or sets the bounds.</param>
        /// <param name="dateFormat">Gets or sets the dateFormat.</param>
        /// <param name="radioGroupName">Gets or sets the radioGroupName.</param>
        public TextTagDefinition(
            string definitionId,
            FieldType type,
            int signerIndex,
            bool isRequired,
            string placeholder = default,
            string fieldId = default,
            Font font = default,
            Validation validation = default,
            Size size = default,
            string dateFormat = default,
            string radioGroupName = default)
        {
            this.DefinitionId = definitionId;
            this.Type = type;
            this.SignerIndex = signerIndex;
            this.IsRequired = isRequired;
            this.Placeholder = placeholder;
            this.FieldId = fieldId;
            this.Font = font;
            this.Validation = validation;
            this.Size = size;
            this.DateFormat = dateFormat;
            this.RadioGroupName = radioGroupName;
        }

        /// <summary>
        /// Gets or sets DefinitionId.
        /// </summary>
        [DataMember(Name = "definitionId", EmitDefaultValue = false)]
        public string DefinitionId { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public FieldType Type { get; set; }

        /// <summary>
        /// Gets or sets SignerIndex.
        /// </summary>
        [Range(1, 50)]
        [DataMember(Name = "signerIndex", EmitDefaultValue = false)]
        public int SignerIndex { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether field is required.
        /// </summary>
        [DataMember(Name = "isRequired", EmitDefaultValue = false)]
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or sets placeholder for textbox.
        /// </summary>
        [DataMember(Name = "placeholder", EmitDefaultValue = false)]
        public string Placeholder { get; set; }

        /// <summary>
        /// Gets or sets FieldId.
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or sets Font.
        /// </summary>
        [DataMember(Name = "font", EmitDefaultValue = false)]
        public Font Font { get; set; }

        /// <summary>
        /// Gets or sets Validation.
        /// </summary>
        [DataMember(Name = "validation", EmitDefaultValue = false)]
        public Validation Validation { get; set; }

        /// <summary>
        /// Gets or sets Bounds.
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public Size Size { get; set; }

        /// <summary>
        /// Gets or sets DateFormat.
        /// </summary>
        [DataMember(Name = "dateFormat", EmitDefaultValue = false)]
        public string DateFormat { get; set; }

        /// <summary>
        /// Gets or sets RadioGroupName.
        /// </summary>
        [DataMember(Name = "radioGroupName", EmitDefaultValue = false)]
        public string RadioGroupName { get; set; }
    }
}