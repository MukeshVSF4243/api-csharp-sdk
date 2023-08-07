﻿// <copyright file="CreateEmbeddedTemplateRequest.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api.Model
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using BoldSign.Model;
    using Newtonsoft.Json;

    /// <summary>
    ///     Embedded send request DTO.
    /// </summary>
    [DataContract(Name = "CreateEmbeddedTemplateRequest")]
    public class CreateEmbeddedTemplateRequest : CreateTemplateRequest
    {
        /// <summary>
        /// Gets or sets the RedirectUrl.
        /// </summary>
        [JsonProperty("redirectUrl")]
        public Uri RedirectUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show tool bar.
        /// </summary>
        [JsonProperty("showToolbar")]
        public bool ShowToolbar { get; set; }

        /// <summary>
        /// Gets or sets the create view option.
        /// </summary>
        [JsonProperty("viewOption")]
        public PageViewOption ViewOption { get; set; } = PageViewOption.PreparePage;

        /// <summary>
        /// Gets or sets a value indicating whether to show save button.
        /// </summary>
        [JsonProperty("showSaveButton")]
        public bool ShowSaveButton { get; set; } = true;

        /// <summary>
        /// Gets or sets the locale.
        /// </summary>
        [JsonProperty("locale")]
        public Locales Locale { get; set; } = Locales.EN;

        /// <summary>
        /// Gets or sets a value indicating whether to show send button.
        /// </summary>
        [Obsolete("ShowSendButton is deprecated, please use ShowCreateButton instead.")]
        [JsonProperty("showSendButton")]
        public bool? ShowSendButton { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show create button.
        /// </summary>
        [JsonProperty("showCreateButton")]
        public bool ShowCreateButton { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to show preview button.
        /// </summary>
        [JsonProperty("showPreviewButton")]
        public bool ShowPreviewButton { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to show navigation buttons.
        /// </summary>
        [JsonProperty("showNavigationButtons")]
        public bool ShowNavigationButtons { get; set; } = true;

        /// <summary>
        /// Gets or sets a expiry date for create link.
        /// Maximum valid till is 180 days.
        /// Default is 30 days.
        /// </summary>
        [JsonProperty("linkValidTill")]
        public DateTime? LinkValidTill { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show tool tip.
        /// </summary>
        [JsonProperty("showTooltip")]
        public bool ShowTooltip { get; set; }

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
