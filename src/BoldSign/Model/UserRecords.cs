// <copyright file="UserRecords.cs" company="Syncfusion Inc">
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

    /// <summary>
    ///     The current page records view model.
    /// </summary>
    [DataContract]
    public class UserRecords
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRecords" /> class.
        /// </summary>
        /// <param name="pageDetails">pageDetails.</param>
        /// <param name="result">Gets or sets the documents result..</param>
        public UserRecords(UserPageDetails pageDetails = default, List<UsersDetails> result = default)
        {
            this.Result = result;
            this.PageDetails = pageDetails;
        }

        /// <summary>
        ///  Gets or Sets page details.
        /// </summary>
        [DataMember(Name = "pageDetails", EmitDefaultValue = false)]
        public UserPageDetails PageDetails { get; set; }

        /// <summary>
        ///  Gets or sets the document results.
        /// </summary>
        /// <value>Gets or sets the documents result.</value>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public List<UsersDetails> Result { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
