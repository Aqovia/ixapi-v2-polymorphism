/* 
 * IX-API
 *
 *  This API allows to config/change/delete Internet Exchange services.  # Filters  When querying collections, the provided query parameters are validated. Unknown query parameters are ignored. Providing invalid filter values should yield a validation error. 
 *
 * OpenAPI spec version: 2.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Client
{
    /// <summary>
    /// Formatter for 'date' swagger formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types
    /// </summary>
    public class SwaggerDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerDateConverter" /> class.
        /// </summary>
        public SwaggerDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
