package Gorain;
import java.util.Scanner;
/**
 * Factorial Method
 * Finds the factorial of an entered number
 * @author Snehan
 * April 3 2017
 */
public class Factorial {
	public static void main(String[] args) {
	
		System.out.println("Enter a number");
		Scanner input = new Scanner(System.in);
		int x = 0;
		do{
		System.out.println(factorial(input.nextInt()));
		System.out.println("");
		System.out.println("Enter another number");
		}while(x==0);

	}
	
	public static float factorial(int x){
		//float variable allows for the program to calculate the factorial of larger numbers
		float answer=x;
		
		//numbers under 0 always have the same factorial (-1)
		if (answer<0){
			answer = -1;
			
		}
		else if (answer==0){
			answer = 0;
		}
		else {
		//loops multiplies original integer by each integer below it that is above 0
		for(int i = x-1; i>0 ;i--){
			answer= answer*i;
		}
		}
		
		return answer;
	}

}
