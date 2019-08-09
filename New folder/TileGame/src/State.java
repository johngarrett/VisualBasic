/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-11-17
 
 Description:
	 * this is a super class that defines all sub states 
	 * 	states in this program are like different screens
 What I learned:
 	 * no new concpets here
 Difficulties:  
	 * none
 */
import java.awt.Graphics;

public abstract class State {
	
	private static State currentState = null; //going to hold which state to tick and render
	public State(Handler h){
		handler = h;
	}
	
	//every state must have...
	public abstract void tick();
	public abstract void render(Graphics g);
	protected Handler handler ;
	

	
	//accessor and mutator for state
			public static State getState() {return currentState;}
			public static void setState(State state){currentState = state;}	
}