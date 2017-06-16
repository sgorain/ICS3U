package Culminating;

import lejos.nxt.Motor;
import lejos.robotics.subsumption.Behavior;

public class GoForward implements Behavior {
	
	private boolean suppressed = false;
	
	public boolean takeControl() {
		return true;
	}
	
	@Override
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
