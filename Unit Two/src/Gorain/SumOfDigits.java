package Gorain;
import java.util.Scanner;
/**
 * Sum of Digits Generator
 * Finds the sum of all the digits in an integer
 * @author Snehan Gorain
 * April 4 2017
 */
public class SumOfDigits {
	
	public static void main(String [] args){
		Scanner input = new Scanner(System.in);
		int x = 0;
		System.out.println("Enter a number");
		//do while loop repeats program automatically until program is ended
		do {
			int enteredNumber = input.nextInt();
			System.out.println("The sum of the digits in " + enteredNumber + " is " + (sumOfDigits(enteredNumber)));
			System.out.println("");
			System.out.println("Enter another number");
		}while(x==0);
		
	}
	
	public static int sumOfDigits(int x){
		int sum = 0;
		
		//The loop continues until the original integer is decreased to 0
		//Negative number turned positive
		while (Math.abs(x)>0){
			sum = sum + Math.abs(x)%10; //%10 isolates the last digit in the integer
			x= x/10; //dividing by 10 cuts off the last digit in the integer (it has already been added to sum)
		}
		return sum;
	}

}
