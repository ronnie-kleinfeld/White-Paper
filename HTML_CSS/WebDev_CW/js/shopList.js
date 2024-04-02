var sc_shopArray = new Array()

let shopInnerId = 0;

const res_image_path = "./images/products/";

// item
function addItemToShop(title, description, price, quantity, size, image_src, alt) {
    let item = {
        id: shopInnerId,
        title: title,
        description: description,
        price: price,
        quantity: quantity,
        size: size,
        image_src: res_image_path + image_src,
        alt: alt
    }

    sc_shopArray.push(item)

    shopInnerId = shopInnerId + 1;
}

// shop
addItemToShop("White Bag", "White Bag with Logo", 9.99, 1, "Medium", "product1.png", "White Bag")
addItemToShop("Black Bag", "Black Bag with Logo", 9.99, 1, "Large", "product2.png", "Black Bag")
addItemToShop("Key Chain", "Key Chain with Logo", 1.99, 1, "Large", "product3.png", "Key Chain")
addItemToShop("Notebook", "Notebook with Logo", 4.99, 1, "Small", "product4.png", "Notebook")
addItemToShop("Black T-Shirt", "Black T-Shirt with Logo", 19.99, 1, "Small", "product5.png", "Black T-Shirt")
addItemToShop("Black T-Shirt", "Black T-Shirt with Logo", 19.99, 1, "Small", "product6.png", "Black T-Shirt")