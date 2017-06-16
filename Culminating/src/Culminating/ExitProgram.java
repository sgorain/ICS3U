package Culminating;
import lejos.nxt.Button;
import lejos.robotics.subsumption.Behavior;

/*
 * Ends entire program when the escape button is pressed
 * @author 334752052
 * Snehan Gorain
 * 15/06/2017
 */
/*ExitProgram.java */
public class ExitProgram implements Behavior{

    private boolean suppressed = true;
    //Exits when escape button is pressed
	public boolean takeControl() {
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
