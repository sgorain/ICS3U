package PACKAGENAME;
import java.util.Scanner;
public class isPrime {
	public static void main(String [] args){
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Enter a number");
		int input = sc.nextInt();
		System.out.println(isPrime(input));
	}
	
	public static boolean isPrime(int x){
		for (int i=2; i<x; i++){
			if(x%i==0){
				return false;
			}
		}
		return true;
		
	}

}
