// <copyright file="DropdownField.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    /*
 * BoldSign API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization;
    using BoldSign.Api.Resources;
    using Newtonsoft.Json;

    /// <summary>
    /// DropdownField.
    /// </summary>
    [DataContract]
    public class DropdownField : FormField
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DropdownField" /> class.
        /// </summary>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="bounds">bounds (required).</param>
        /// <param name="isRequired">isRequired.</param>
        /// <param name="value">value.</param>
        /// <param name="fontSize">fontSize.</param>
        /// <param name="font">font (required).</param>
        /// <param name="isUnderLineFont">isUnderLineFont.</param>
        /// <param name="fontHexColor">fontHexColor.</param>
        /// <param name="isBoldFont">isBoldFont.</param>
        /// <param name="isItalicFont">isItalicFont.</param>
        /// <param name="lineHeight">lineHeight.</param>
        /// <param name="dropdownOptions">dropdownOptions.</param>
        /// <param name="placeholder">placeHolder.</param>
        /// <param name="id">id.</param>
        /// <param name="dataSyncTag">dataSyncTag.</param>
        /// <param name="conditionalRules">Gets or sets the conditionalRules.</param>
        public DropdownField(int pageNumber = default, Rectangle bounds = default, bool isRequired = default, string value = default, bool isUnderLineFont = default, FontFamily font = FontFamily.Helvetica, int fontSize = default, string fontHexColor = default, bool isBoldFont = default, bool isItalicFont = default, int lineHeight = default, List<string> dropdownOptions = default(List<string>), string placeholder = default(string), string id = default(string), string dataSyncTag = default(string), List<ConditionalRule> conditionalRules = default)
            : base(type: FieldType.Dropdown, pageNumber: pageNumber, bounds: bounds, isRequired: isRequired, value: value, font: font, fontSize: fontSize, fontHexColor: fontHexColor, isUnderLineFont: isUnderLineFont, isBoldFont: isBoldFont, isItalicFont: isItalicFont, lineHeight: lineHeight, id: id, dataSyncTag: dataSyncTag, conditionalRules: conditionalRules)
        {
            if (dropdownOptions == null || dropdownOptions.Count < 1)
            {
                throw new InvalidDataException(ApiValidationMessages.RequiredDropdownOptions);
            }
            else
            {
                var emptyOption = dropdownOptions.Any(option => string.IsNullOrEmpty(option));
                if (emptyOption)
                {
                    throw new InvalidDataException(ApiValidationMessages.InvalidDropdownOption);
                }

                var isDuplicate = dropdownOptions.Any(option1 => dropdownOptions.Where(option2 => option1.ToUpperInvariant() == option2.ToUpperInvariant()).Count() > 1);
                if (isDuplicate)
                {
                    throw new InvalidDataException(ApiValidationMessages.DuplicateDropdownOption);
                }

                var isValid = dropdownOptions.Any(dropdownOption => string.IsNullOrEmpty(value) || dropdownOption.ToUpperInvariant() == value.ToUpperInvariant());
                if (!isValid)
                {
                    throw new InvalidDataException(ApiValidationMessages.InvalidDefaultOption);
                }
            }

            this.DropdownOptions = dropdownOptions;
            this.Placeholder = placeholder;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DropdownField" /> class.
        /// </summary>
        [JsonConstructor]
        protected DropdownField()
        {
        }

        /// <summary>
        /// Gets or Sets Placeholder value.
        /// </summary>
        [DataMember(Name = "placeholder", EmitDefaultValue = false)]
        public string Placeholder { get; set; }

        /// <summary>
        /// Gets or Sets Dropdown Options.
        /// </summary>
        [DataMember(Name = "dropdownOptions", EmitDefaultValue = false)]
        public List<string> DropdownOptions { get; set; }

        /// <summary>
        /// Gets or sets the form field type.It is a read only property.
        /// </summary>
        [DataMember(Name = "fieldType", EmitDefaultValue = true)]
        public override FieldType Type
        {
            get => base.m_type;
            set { throw new Exception("Read only"); }
        }
    }
}