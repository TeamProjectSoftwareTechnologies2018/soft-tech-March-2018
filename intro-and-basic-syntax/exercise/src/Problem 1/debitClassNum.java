import com.sun.org.apache.xpath.internal.SourceTree;
import java.util.Scanner;


public class debitClassNum {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
		// read firstNum
        int firstNum = Integer.parseInt(scanner.nextLine());
		// read secondNum
        int secondNum = Integer.parseInt(scanner.nextLine());
		// read thirdNum
        int thirdNum = Integer.parseInt(scanner.nextLine());
		// read fourthNum
        int fourthNum = Integer.parseInt(scanner.nextLine());
		// print all Nums
        System.out.printf("%04d %04d %04d %04d", firstNum, secondNum, thirdNum, fourthNum);

    }
}
