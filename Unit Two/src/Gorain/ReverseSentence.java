package Gorain;
import java.util.Scanner;
public class ReverseSentence {
	
	/**
	 * Reverse Sentence
	 * Prints a sentence (input) with the letters in each word in reverse order
	 * @author Snehan Gorain
	 * April 7 2017
	 */
	
	public static void main(String[] args){
		Scanner sc = new Scanner (System.in);
		System.out.println("Enter a sentence");
		String [] phrase = sc.nextLine().split(" ");
		
		for(int i = 0; i<phrase.length; i++){
			for(int counter = phrase[i].length(); counter > 0; counter--){
				
					System.out.print(phrase[i].charAt(counter-1));
			}
			System.out.print(" ");
		}
	}
}
	