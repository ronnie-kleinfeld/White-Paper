var sc_cartArray = new Array()

let cartInnerId = 0;

// item
function sc_addCartItem(shopId, title, description, price, quantity, size, image_src, alt) {
    let item = {
        id: shopInnerId,
        shopId: shopId,
        title: title,
        description: description,
        price: price,
        quantity: quantity,
        size: size,
        image_src: image_src,
        alt: alt
    }
    shopInnerId = shopInnerId + 1;
    sc_cartArray.push(item);
    save();
    return item;
}

function sc_deleteCartItem(index) {
    sc_cartArray.splice(index, 1);
    save();
}

function sc_clearCart() {
    sc_cartArray = new Array();
    save();
}

function sc_cartTotal() {
    let result = 0;
    for (var i = 0; i < sc_cartArray.length; i++) {
        result += parseFloat(sc_cartArray[i].price) * parseFloat(sc_cartArray[i].quantity);
    }
    return result;
}

function sc_toFeedback() {
    let result = sc_cartArray.length + " items:\n";
    let total = 0;
    for (var i = 0; i < sc_cartArray.length; i++) {
        let item = sc_cartArray[i];
        let price = parseFloat(item.price);
        let quantity = parseFloat(item.quantity);
        cost = item.price * item.quantity;
        result += item.title + " $" + price.toFixed(2) + "x" + quantity + "=" + cost.toFixed(2) + " Size:" + item.size + "\n";

        total += cost;
    }
    result += "Total: " + total.toFixed(2);
    return result;
}

function load() {
    sc_cartArray = JSON.parse(localStorage.getItem("cart")) || [];
}
function save() {
    localStorage.setItem("cart", JSON.stringify(sc_cartArray));
}

load();