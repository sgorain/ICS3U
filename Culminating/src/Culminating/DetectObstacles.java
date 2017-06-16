package Culminating;

import lejos.nxt.Motor;
import lejos.nxt.SensorPort;
import lejos.nxt.UltrasonicSensor;
import lejos.robotics.subsumption.Behavior;

public class DetectObstacles implements Behavior {
	private boolean suppressed = false;
	private UltrasonicSensor sonar = new UltrasonicSensor(SensorPort.S4);
	
	public boolean takeControl (){
		
		//Detects obstacle
		if (sonar.getDistance()<20){
			return true;
		}
		return false;
	}
	
	public void action () {
		Motor.A.stop();
		Motor.B.stop();
	
		Motor.A.rotate(360);
		
		
		if(sonar.getDistance()<20){
			Motor.A.rotate(-720);
		}
		
		Motor.A.forward();
		Motor.B.forward();

	}
	
	public void suppress () {
		suppressed = true;
	}

}
