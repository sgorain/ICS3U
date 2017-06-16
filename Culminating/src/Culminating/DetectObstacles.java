package Culminating;

import lejos.nxt.Motor;
import lejos.nxt.SensorPort;
import lejos.nxt.UltrasonicSensor;
import lejos.robotics.subsumption.Behavior;
/**
 * Detects an obstacle and turns away
 * @author 334752052
 * Snehan Gorain
 * 15/06/2017
 */
public class DetectObstacles implements Behavior {
	private boolean suppressed = false;
	private UltrasonicSensor sonar = new UltrasonicSensor(SensorPort.S4);
	
	// Takes control when obstacle is detected
	public boolean takeControl (){
		
		//Detects obstacle
		if (sonar.getDistance()<20){
			return true;
		}
		return false;
	}
	//Robot stops, rotates, and continues forward
	public void action () {
		Motor.A.stop();
		Motor.B.stop();
	
		Motor.A.rotate(360); //rotates 90 degrees
		
		//If there is another obstacle 90 degrees awat from the original direction
		if(sonar.getDistance()<20){
			Motor.A.rotate(-720); //rotates the opposite way 180 degrees
		}
		
		Motor.A.forward();
		Motor.B.forward();

	}
	
	public void suppress () {
		suppressed = true;
	}

}
