package Culminating;

import lejos.robotics.subsumption.Arbitrator;
import lejos.robotics.subsumption.Behavior;

public class MyArbitrator {

	public static void main(String [] args){
		Behavior b1 = new GoForward();
		Behavior b2 = new ExitProgram();
		Behavior b3 = new DetectObstacles(); //Detects an object in the way and turns away
		Behavior b4 = new DetectFinish(); //Detects white paper or tape on the table/ground - program ends
		Behavior [] tasks = { b1, b3, b4, b2};
		
		Arbitrator arby = new Arbitrator(tasks);
		arby.start();
	}
}
