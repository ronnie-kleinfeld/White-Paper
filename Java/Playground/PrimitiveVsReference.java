import java.util.Date;
import java.awt.*;

public class PrimitiveVsReference {
    public static void main(String[] args) {
        int x = 5;
        int y = x;
        System.out.println(x); // 5
        System.out.println(y); // 5

        x = 2;
        System.out.println(x); // 2
        System.out.println(y); // 5

        Point point1 = new Point(1, 1);
        Point point2 = point1;
        System.out.println(point1); // java.awt.Point[x=1,y=1]
        System.out.println(point2); // java.awt.Point[x=1,y=1]

        point1.x = 2;
        System.out.println(point1); // java.awt.Point[x=2,y=1]
        System.out.println(point2); // java.awt.Point[x=2,y=1]
    }
}
