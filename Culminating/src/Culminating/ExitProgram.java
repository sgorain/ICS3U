package Culminating;
import lejos.nxt.Button;
import lejos.robotics.subsumption.Behavior;



/*ExitProgram.java */
public class ExitProgram implements Behavior{

    private boolean suppressed = true;
    
	public boolean takeControl() {
		//To exit program
		if(Button.ESCAPE.isDown())
			return true;
		return false;
	}
	
	//Exits program
	@Override
	public void action() {
		System.exit(0);
	}
	
	@Override
	public void suppress() {
		suppressed = true;
	}
}
