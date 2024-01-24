using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http.Routing;

namespace Routing.Enum {
    /// <code>
    ///   [HttpGet, Route("colors/{color:enum(My.Namespace.ColorsEnum)}")]
    ///   public string GetColor(string color)
    ///   {
    ///      return color;
    ///   }
    /// </code>
    /// </remarks>
    public class EnumRouteConstraint : IHttpRouteConstraint {
        /// <summary>
        /// Hold the type of the Enum class to validate against
        /// </summary>
        private readonly Type _enum;

        /// <summary>
        /// Constructor taking a namespace-qualified type name of the Enum type to use
        /// </summary>
        public EnumRouteConstraint(string type) {
            var t = GetType(type);

            if (t == null || !t.IsEnum) {
                throw new ArgumentException("Argument is not an Enum type", "type");
            }
            _enum = t;
        }

        /// <summary>
        /// Internal method to convert the string enum type name into a Type instance by checking all of the currently loaded assemblies
        /// </summary>
        private static Type GetType(string typeName) {
            var type = Type.GetType(typeName);
            if (type != null) {
                return type;
            }
            foreach (var a in AppDomain.CurrentDomain.GetAssemblies()) {
                type = a.GetType(typeName);
                if (type != null) {
                    return type;
                }
            }
            return null;
        }

        /// <summary>
        /// IHttpRouteConstraint.Match implementation to validate a parameter against the Enum members. String comparison is NOT case-sensitive.
        /// </summary>
        public bool Match(HttpRequestMessage request, IHttpRoute route, string parameterName, IDictionary<string, object> values, HttpRouteDirection routeDirection) {
            object value;

            if (values.TryGetValue(parameterName, out value) && value != null) {
                var stringVal = value as string;
                if (!string.IsNullOrEmpty(stringVal)) {
                    // see if we can find the string in the enumeration members
                    stringVal = stringVal.ToLower();
                    if (null != _enum.GetEnumNames().FirstOrDefault(a => a.ToLower().Equals(stringVal))) {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}