import java.util.Scanner;

public class MainClass {
    public static void main(String[] args) {
        // We add scanner util so we can read input
        Scanner scanner=new Scanner(System.in);
        // we read our input -> side a
        double a=scanner.nextDouble();
        // we read our input -> side b
        double b=scanner.nextDouble();
        // we calculate the area using the formula area = a * b
        double area=a*b;
        // we print the result to the second digit after the decimal point
        System.out.printf("%.2f", area);
    }
}
