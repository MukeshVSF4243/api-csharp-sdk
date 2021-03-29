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
    ///     The page details.
    /// </summary>
    [DataContract]
    public class PageDetails
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PageDetails" /> class.
        /// </summary>
        /// <param name="pageSize">Gets or sets the page size..</param>
        /// <param name="page">Gets or sets the page..</param>
        /// <param name="totalRecordsCount">Gets or sets the total records count..</param>
        /// <param name="totalPages">Gets or sets the total pages..</param>
        /// <param name="sortedColumn">Gets or sets the sorted column..</param>
        /// <param name="sortDirection">Gets or sets the sort direction..</param>
        public PageDetails(int pageSize = default, int page = default, int totalRecordsCount = default, int totalPages = default, string sortedColumn = default, string sortDirection = default)
        {
            this.SortedColumn = sortedColumn;
            this.SortDirection = sortDirection;
            this.PageSize = pageSize;
            this.Page = page;
            this.TotalRecordsCount = totalRecordsCount;
            this.TotalPages = totalPages;
            this.SortedColumn = sortedColumn;
            this.SortDirection = sortDirection;
        }

        /// <summary>
        ///     Gets or sets the page size.
        /// </summary>
        /// <value>Gets or sets the page size.</value>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        ///  Gets or sets the page.
        /// </summary>
        /// <value>Gets or sets the page.</value>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the total record count.
        /// </summary>
        /// <value>Gets or sets the total records count.</value>
        [DataMember(Name = "totalRecordsCount", EmitDefaultValue = false)]
        public int TotalRecordsCount { get; set; }

        /// <summary>
        ///  Gets or sets the total page count.
        /// </summary>
        /// <value>Gets or sets the total pages.</value>
        [DataMember(Name = "totalPages", EmitDefaultValue = false)]
        public int TotalPages { get; set; }

        /// <summary>
        ///  Gets or sets the sorted column.
        /// </summary>
        /// <value>Gets or sets the sorted column.</value>
        [DataMember(Name = "sortedColumn", EmitDefaultValue = true)]
        public string SortedColumn { get; set; }

        /// <summary>
        ///  Gets or sets the sort direction.
        /// </summary>
        /// <value>Gets or sets the sort direction.</value>
        [DataMember(Name = "sortDirection", EmitDefaultValue = true)]
        public string SortDirection { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}