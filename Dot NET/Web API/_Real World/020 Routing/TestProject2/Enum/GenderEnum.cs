using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Routing.Enum {
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GenderEnum {
        Male,
        Female,
        Other
    }
}