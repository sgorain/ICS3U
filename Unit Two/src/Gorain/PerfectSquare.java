package Gorain;

public class PerfectSquare {
	public static void main(String[] arg){
		System.out.println("a-b-c");
		for(int i = 1; i<100; i++){
			for(int i2 = 1; i2<100; i2++){
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
