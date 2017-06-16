package Gorain;
import java.util.Scanner;
/**
 * Largest Number Finder
 * Finds the largest number from a set of numbers
 * @author Snehan Gorain
 * April 4 2017
 */
public class LargestNumber {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in); 
		System.out.println("How many numbers would you like to enter?");
		double [] numberArray = new double [input.nextInt()];
		
		//Loop to place number in each spot of the array
		for (int counter = 0; counter< numberArray.length; counter++){
			System.out.println("Enter number " + (counter+1));
			numberArray [counter] = input.nextDouble();
			
		}
		
		System.out.println("The largest number is "+ largestNumber(numberArray));
	

	}
	
	public static double largestNumber(double [] x){
		//Temporary value of largest number until larger ones are found
		double maximumNumber = x[0]; //largest number variable
		
		/**Previous value of the largest number replaced with a larger value if
		it is found in the remaining spots in the array*/
		for(int counter = 1; counter<x.length; counter ++){
			if(maximumNumber< x[counter]){
				maximumNumber = x[counter]; /** Replaces the previous value of maximum
				number with the newly found larger value*/
			}
		}
		return maximumNumber;
	}

}
