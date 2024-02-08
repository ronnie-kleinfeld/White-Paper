using Di.Libraries.Services.ShoppingCart;
using Di.Libraries.Services.Storage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Di.Web.Mvc.Controllers {
    public class BaseController : Controller {
        const string SHOPPING_CART_ID_COOKIE_NAME = "shoppingCartId";

        public override void OnActionExecuting(ActionExecutingContext filterContext) {
            var storageService = filterContext.HttpContext.RequestServices.GetRequiredService<IStorageService>();
            var shoppingCartService = filterContext.HttpContext.RequestServices.GetRequiredService<IShoppingCartService>();

            var shoppingCartIdCookie = Request.Cookies[SHOPPING_CART_ID_COOKIE_NAME];
            var hasShoppingCartCookie = Guid.TryParse(shoppingCartIdCookie, out var shoppingCartId);

            if (!hasShoppingCartCookie) {
                shoppingCartId = Guid.NewGuid();
            }

            filterContext.HttpContext.Response.Cookies.Append(SHOPPING_CART_ID_COOKIE_NAME, shoppingCartId.ToString(), new CookieOptions {
                Path = "/",
                Expires = DateTimeOffset.UtcNow.AddMinutes(10)
            });

            storageService.AddShoppingCart(shoppingCartId);
            shoppingCartService.SetId(shoppingCartId);

            base.OnActionExecuting(filterContext);
        }
    }
}