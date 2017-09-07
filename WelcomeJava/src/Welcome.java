import java.util.Scanner;

public class Welcome {
    public static void main(String[] args) {
        System.out.println("Hello and Welcome to Java!");
        System.out.print("Please tell me your name: ");
        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();
        System.out.println(String.format("Hello, %s!", name));
    }
}
