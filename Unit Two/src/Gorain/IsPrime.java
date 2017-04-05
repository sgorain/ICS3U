package Gorain;
import java.util.Scanner;
public class IsPrime {
	/**
	 * isPrime
	 * Determines if an entered number is prime or not prime
	 * @author Snehan Gorain
	 * April 3 2017
	 */
	public static void main(String [] args){
		Scanner input = new Scanner(System.in);
		int x = 0;
		System.out.println("Enter a number");
		//Do loops repeats the program 
		do{
		int enteredNumber = input.nextInt();
		if (isDivisible(enteredNumber)){
			System.out.println(enteredNumber+" is prime" );
		}
		else{
			System.out.println(enteredNumber+ " is not prime");
		}
		System.out.println("");
		System.out.println("Enter another number");
		}while(x==0);
	}
	
	public static boolean isDivisible(int x){
		//Changed negative numbers into positive
		if(x<0){
			x=x*(-1);
		}
		
		//0 is an exception to the algorithm; it is always prime
		if(x==0){
			return true;
		}
		
		//Tests divisibility by numbers 2 to x-1
		for (int i=2; i<x; i++){
			if(x%i==0){
				return false;
			}
		}
		return true;
	}

}
