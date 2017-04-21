package Gorain;
import java.util.Scanner;
/**
 * Perfect Number
 * Prints all the perfect numbers within a range
 * @author Snehan Gorain
 * April 20 2017
 */
public class PerfectNumber {
	public static void main(String [] args){
		Scanner input = new Scanner(System.in);
		System.out.println("Enter a range");
		System.out.print("1-");
		int range = input.nextInt();
		System.out.println("Following are the perfect numbers between 1 and " + range);
		for(int counter = 1; counter<= range; counter++){
			if(perfectNumber(counter)){
				System.out.println(counter);
			}
		}
		
	}
	
	public static boolean perfectNumber(int x){
		int sum = 0; 
		for(int i = x-1; i>0; i--){
			if(x%i==0){
				sum = sum + i;
			}
		}
		if(sum==x){
			return true;
		}
		return false;
	}

}
