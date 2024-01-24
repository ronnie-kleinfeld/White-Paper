using System.Collections.Generic;
using System.Web.Http;

namespace Routing.Controllers.OLD {
    public class OrdersController : ApiController {
        // GET orders/<order Id>
        [HttpGet, Route("orders/{id:length(8)}", Order = 2)]
        public string GetOrderById(string id) {
            return "order-" + id;
        }

        // GET orders/pending,  orders/complete, etc.
        [HttpGet, Route("orders/{status:regex(^(?i)(new|complete|pending)$)}", Order = 1)]
        public IEnumerable<string> GetOrdersWithStatus() {
            return new string[] { "status1", "status2" };
        }
    }
}