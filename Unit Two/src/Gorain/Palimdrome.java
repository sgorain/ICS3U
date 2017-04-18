package Gorain;
import java.util.Scanner;
public class Palimdrome {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.println("Enter a word");
		String original = scan.nextLine();
		System.out.println(palimdrome(original));

	}
	
	public static boolean palimdrome(String original){
	String reverse="";
	for(int counter = original.length()-1;counter>=0; counter--){
		reverse = reverse + original.charAt(counter);
	}
	
	if(original.equals(reverse)){
		return true;
	}
	return false;

	}

}
