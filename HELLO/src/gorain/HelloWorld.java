package gorain;

import java.util.Scanner;

/**
 * Hello Word
 * Program
 * @author Snehan
 * February 21
 */
public class HelloWorld {
static Scanner scan = new Scanner(System.in);
	public static void main(String[] args) {
		System.out.println("Hello, World!!!");
		String name = scan.nextLine();
		System.out.println("Hi "+ name);

	}

}
