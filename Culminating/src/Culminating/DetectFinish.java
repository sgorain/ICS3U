package Culminating;

import lejos.nxt.LightSensor;
import lejos.nxt.Motor;
import lejos.nxt.SensorPort;
import lejos.nxt.Sound;
import lejos.robotics.subsumption.Behavior;

public class DetectFinish implements Behavior{
	private boolean suppressed = false;
	private LightSensor light = new LightSensor(SensorPort.S2);
	
	public boolean takeControl(){
		//Detects white paper or tape - indicates finish of obstacle course
		if(light.getLightValue()>50){
			return true;
		}
		return false;
	}
	
	public void action () {
		Sound.beep();
		Sound.beep();
		Sound.beep();
		
		System.exit(0);
	
	}
	
	public void suppress () {
		suppressed = true;
	}
	

}
