using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http.Routing;

namespace Routing.Enum {
    public class EnumRouteConstraint : IHttpRouteConstraint {
        private readonly Type _enum;

        public EnumRouteConstraint(string type) {
            var t = GetType(type);

            if (t == null || !t.IsEnum) {
                throw new ArgumentException("Not an Enum type", "type");
            }
            _enum = t;
        }

        /// Internal method to convert the string enum type name into a Type instance by checking all of the currently loaded assemblies
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

        public bool Match(HttpRequestMessage request, IHttpRoute route, string parameterName, IDictionary<string, object> values, HttpRouteDirection routeDirection) {
            object value;

            if (values.TryGetValue(parameterName, out value) && value != null) {
                var stringVal = value as string;
                if (!string.IsNullOrEmpty(stringVal)) {
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