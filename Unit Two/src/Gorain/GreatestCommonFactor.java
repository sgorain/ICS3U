package Gorain;
import java.util.Scanner;
public class GreatestCommonFactor {
/**
 * Greatest Common Factor
 * Finds the greatest common factor of an entered number
 * @author Snehan Gorain
 * April 3 2017
 */
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int x = 0;
		do{
		System.out.println("Enter a number");
		int enteredNumber1 = input.nextInt();
		System.out.println("Enter another number");
		int enteredNumber2 = input.nextInt();
		System.out.println("");
		System.out.println("The greatest common factor of numbers "+ enteredNumber1 +" and "+ enteredNumber2+ " is "+(gcf(enteredNumber1, enteredNumber2)));
		System.out.println("");
		} while(x == 0);

	}
	
	public static int gcf(int x, int y){
		//All numbers have a gcf of 1
		int gcf = 1;
		
		//variable 'i' is tested for divisibility into both integers x & y
		//the largest 'i' value the loop reaches that is smaller or equal to both x & y is the gcf
		for(int i = 2; i<= x && i<= y; i++){
			if(x%i == 0 && y%i == 0){
				gcf = i;
			}
		}
		return gcf;
	}

}
