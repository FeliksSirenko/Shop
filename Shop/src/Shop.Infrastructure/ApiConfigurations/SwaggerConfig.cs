using Shop.Infrastructure.ApiConfigurations.EmbeddedConfigurations;

namespace Shop.Infrastructure.ApiConfigurations
{
    /// <summary>
    /// Swagger configuration information.
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// Gets or sets version of an API.
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets title of an API.
        /// </summary>
        public string ApiTitle { get; set; }

        /// <summary>
        /// Gets or sets the description to an API.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Swagger endpoint Url.
        /// </summary>
        public string EndpointUrl { get; set; }

        /// <summary>
        /// Gets or sets Api owner.
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Gets or sets license.
        /// </summary>
        public License License { get; set; }
    }
}
