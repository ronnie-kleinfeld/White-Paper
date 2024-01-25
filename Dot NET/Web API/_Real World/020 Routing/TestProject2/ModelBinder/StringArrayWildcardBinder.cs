using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;

namespace Routing.ModelBinder {
    /// Custom model binder for a string array
    public class StringArrayWildcardBinder : IModelBinder {
        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext) {
            var key = bindingContext.ModelName;
            var val = bindingContext.ValueProvider.GetValue(key);
            if (val != null) {
                var s = val.AttemptedValue;
                if (s != null) {
                    try {
                        var array = s.Split('/');
                        bindingContext.Model = array;
                    } catch {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}