public class Product {
    public static void main(String[] args) {

    }

    public int sugar;
    public int fat;
    public int salt;
    public boolean sugarSticker;
    public boolean fatSticker;
    public boolean saltSticker;

    public Product(int sugar) {
        this.sugar = sugar;
    }

    public boolean isNeeded(int percent, int type) {
        if (type == 1 && this.sugar > percent)
            return true;
        else if (type == 2 && this.fat > percent)
            return true;
        else if (type == 3 && this.fat > percent)
            return true;
        return false;
    }

    public static void checkStickers(Product[] products, int type, int percent) {
        for (int i = 0; i < products.length; i++) {
            Product product = products[i];

            boolean isNeeded = product.isNeeded(percent, type);

            if (type == 1) {
                product.sugarSticker = isNeeded;
            }
            if (type == 2) {
                product.fatSticker = isNeeded;
            }
            if (type == 3) {
                product.saltSticker = isNeeded;
            }
        }
    }
}
