namespace BoldSign.Api
{
    using System.Threading.Tasks;    
    using BoldSign.Model;

    /// <summary>
    ///    Represents a collection of functions to interact with the API endpoints. The functions perform actions such as sending document sign request from template, deleting a template, listing the templates and so on.
    /// </summary>
    public interface ITemplateClient : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Deletes a template with the given template ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template id.</param>
        /// <returns></returns>
        void DeleteTemplate(string templateId);

        /// <summary>
        ///     Deletes a template with the given template ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template id.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> DeleteTemplateWithHttpInfo(string templateId);

        /// <summary>
        ///     List all the templates created.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size. (optional, default to 10)</param>
        /// <param name="templateType">Gets or sets the templateType. (optional, default to all).</param>
        /// <returns>TemplateRecords</returns>
        TemplateRecords ListTemplates(int page, int? pageSize = default, string searchKey = default, TemplateType? templateType = default);

        /// <summary>
        ///     List all the templates created.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size. (optional, default to 10)</param>
        /// <param name="templateType">Gets or sets the templateType. (optional, default to all).</param>
        /// <returns>ApiResponse of TemplateRecords</returns>
        ApiResponse<TemplateRecords> ListTemplatesWithHttpInfo(int page, int? pageSize = default, string searchKey = default, TemplateType? templateType = default);

        /// <summary>
        ///     Send a document for signature using a Template.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sendForSignFromTemplate">It contains page,page size and status details. (optional)</param>
        /// <returns>DocumentCreated</returns>
        DocumentCreated SendUsingTemplate(SendForSignFromTemplate sendForSignFromTemplate = default);

        /// <summary>
        ///     Send a document for signature using a Template.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sendForSignFromTemplate">It contains page,page size and status details. (optional)</param>
        /// <returns>ApiResponse of DocumentCreated</returns>
        ApiResponse<DocumentCreated> SendUsingTemplateWithHttpInfo(SendForSignFromTemplate sendForSignFromTemplate = default);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Deletes a template with the given template ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template id.</param>
        /// <returns>Task of void</returns>
        Task DeleteTemplateAsync(string templateId);

        /// <summary>
        ///     Deletes a template with the given template ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">The template id.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> DeleteTemplateAsyncWithHttpInfo(string templateId);

        /// <summary>
        ///     List all the templates created.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size. (optional, default to 10)</param>
        /// <param name="templateType">Gets or sets the templateType. (optional, default to all).</param>
        /// <returns>Task of TemplateRecords</returns>
        Task<TemplateRecords> ListTemplatesAsync(int page, int? pageSize = default, string searchKey = default, TemplateType? templateType = default);

        /// <summary>
        ///    List all the templates created.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Gets or sets the page.</param>
        /// <param name="pageSize">Gets or sets the page size. (optional, default to 10)</param>
        /// <param name="templateType">Gets or sets the templateType. (optional, default to all).</param>
        /// <returns>Task of ApiResponse (TemplateRecords)</returns>
        Task<ApiResponse<TemplateRecords>> ListTemplatesAsyncWithHttpInfo(int page, int? pageSize = default, string searchKey = default, TemplateType? templateType = default);

        /// <summary>
        ///     Send a document for signature using a Template.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sendForSignFromTemplate">It contains page,page size and status details. (optional)</param>
        /// <returns>Task of DocumentCreated</returns>
        Task<DocumentCreated> SendUsingTemplateAsync(SendForSignFromTemplate sendForSignFromTemplate = default);

        /// <summary>
        ///     Send a document for signature using a Template.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sendForSignFromTemplate">It contains page,page size and status details. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentCreated)</returns>
        Task<ApiResponse<DocumentCreated>> SendUsingTemplateAsyncWithHttpInfo(SendForSignFromTemplate sendForSignFromTemplate = default);

        /// <summary>
        ///     Embedded send a document for signature using a template.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="send">It contains page,page size and status details.</param>
        /// <returns>An ApiResponse (DocumentCreated).</returns>
        EmbeddedSendCreated CreateEmbeddedRequestUrl(EmbeddedTemplateRequest send = default);

        /// <summary>
        ///     Embedded send a document for signature using a template.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="send">It contains page,page size and status details.</param>
        /// <returns>An ApiResponse (DocumentCreated).</returns>
        ApiResponse<EmbeddedSendCreated> CreateEmbeddedRequestUrlWithHttpInfo(EmbeddedTemplateRequest send = default);

        /// <summary>
        ///     Embedded send a document for signature using a template.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="send">It contains page,page size and status details.</param>
        /// <returns>Task of ApiResponse (DocumentCreated).</returns>
        Task<EmbeddedSendCreated> CreateEmbeddedRequestUrlAsync(EmbeddedTemplateRequest send = default);

        /// <summary>
        ///     Generates a send URL using a template which embeds document sending process into your application.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="send">It contains page,page size and status details.</param>
        /// <returns>Task of ApiResponse (DocumentCreated).</returns>
        Task<ApiResponse<EmbeddedSendCreated>> CreateEmbeddedRequestUrlAsyncWithHttpInfo(EmbeddedTemplateRequest send = default);

        #endregion Asynchronous Operations
    }
}
