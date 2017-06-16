package Culminating;

import lejos.nxt.Motor;
import lejos.robotics.subsumption.Behavior;
/**
 * Moves forward - last priority
 * @author 334752052
 * Snehan Gorain
 * 15/06/2017
 */
public class GoForward implements Behavior {
	
	private boolean suppressed = false;
	
	//Always take control - all the other priorities are taken care of
	public boolean takeControl() {
		return true;
	}
	
	@Override
	//Continues moving forward
	public void action () {
		suppressed = false;
		Motor.A.forward();
		Motor.B.forward();
		
		while(!suppressed){
			Thread.yield();
		}
		
		Motor.A.stop();
		Motor.B.stop();
	}
	
	@Override
	public void suppress () {
		suppressed = true;
	}
}
