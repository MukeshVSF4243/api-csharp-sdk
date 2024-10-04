﻿// <copyright file="ContactsList.cs" company="Syncfusion Inc">
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
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using BoldSign.Api.Model;

    /// <summary>
    ///  The current page records view model.
    /// </summary>
    [DataContract]
    public class ContactsList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsList" /> class.
        /// </summary>
        /// <param name="pageDetails">pageDetails.</param>
        /// <param name="result">Gets or sets the documents result..</param>
        public ContactsList(ContactPageDetails pageDetails = default, List<ContactsDetails> result = default)
        {
            this.PageDetails = pageDetails;
            this.Result = result;
        }

        /// <summary>
        ///  Gets or sets the page details.
        /// </summary>
        [DataMember(Name = "pageDetails", EmitDefaultValue = false)]
        public ContactPageDetails PageDetails { get; set; }

        /// <summary>
        ///  Gets or sets the contacts results.
        /// </summary>
        /// <value>Gets or sets the contacts result.</value>
        [DataMember(Name = "contactsDetails", EmitDefaultValue = false)]
        public List<ContactsDetails> Result { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
