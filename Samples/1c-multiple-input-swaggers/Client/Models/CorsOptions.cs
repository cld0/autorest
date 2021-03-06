// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Searchservice.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines options to control Cross-Origin Resource Sharing (CORS) for an
    /// index.
    /// <see href="https://msdn.microsoft.com/library/azure/dn798941.aspx" />
    /// </summary>
    public partial class CorsOptions
    {
        /// <summary>
        /// Initializes a new instance of the CorsOptions class.
        /// </summary>
        public CorsOptions()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CorsOptions class.
        /// </summary>
        /// <param name="allowedOrigins">Gets the list of origins from which
        /// JavaScript code will be granted access to your index. Can contain a
        /// list of hosts of the form
        /// {protocol}://{fully-qualified-domain-name}[:{port#}], or a single
        /// '*' to allow all origins (not recommended).</param>
        /// <param name="maxAgeInSeconds">Gets or sets the duration for which
        /// browsers should cache CORS preflight responses. Defaults to 5
        /// mintues.</param>
        public CorsOptions(IList<string> allowedOrigins, long? maxAgeInSeconds = default(long?))
        {
            AllowedOrigins = allowedOrigins;
            MaxAgeInSeconds = maxAgeInSeconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the list of origins from which JavaScript code will be granted
        /// access to your index. Can contain a list of hosts of the form
        /// {protocol}://{fully-qualified-domain-name}[:{port#}], or a single
        /// '*' to allow all origins (not recommended).
        /// </summary>
        [JsonProperty(PropertyName = "allowedOrigins")]
        public IList<string> AllowedOrigins { get; set; }

        /// <summary>
        /// Gets or sets the duration for which browsers should cache CORS
        /// preflight responses. Defaults to 5 mintues.
        /// </summary>
        [JsonProperty(PropertyName = "maxAgeInSeconds")]
        public long? MaxAgeInSeconds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AllowedOrigins == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AllowedOrigins");
            }
        }
    }
}
