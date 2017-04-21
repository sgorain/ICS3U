package Gorain;
import java.util.Scanner;
/**
 * Perfect Square
 * Prints all the perfect numbers within a range
 * @author Snehan Gorain
 * April 20 2017
 */
public class PerfectSquare {
	public static void main(String[] arg){
		Scanner sc = new Scanner(System.in);
		System.out.println("Please enter a range");
		System.out.print("1-");
		int range = sc.nextInt();
		System.out.println();
		System.out.println("Following are values of perfect squares a, b, and c, where a and b range from 1 to "+ range);
		System.out.println("a-b-c");
		System.out.println();
		for(int i = 1; i<range; i++){
			for(int i2 = 1; i2<range; i2++){
				if ((perfectSquare(i, i2))){
					System.out.println(i + "-" + i2 + "-" + (int)Math.sqrt((Math.pow(i, 2) + Math.pow(i2, 2))));
				}
			}

			
		}
	}
	
	public static boolean perfectSquare(int n, int x){
	int hyp = (int)Math.sqrt((Math.pow(n, 2) + Math.pow(x, 2)));
		if(Math.pow(n, 2)+ Math.pow(x, 2)== Math.pow(hyp,2)){
			return true;
		}
		return false;
	}

}
