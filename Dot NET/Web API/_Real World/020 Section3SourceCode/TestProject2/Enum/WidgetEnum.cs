using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TestProject2.Enum {
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WidgetEnum {
        Bolt,
        Screw,
        Nut,
        Motor
    };
}