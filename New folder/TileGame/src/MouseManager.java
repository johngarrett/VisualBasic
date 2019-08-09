/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * This class handles all mouse input
 * What I learned:
 * how mouse clicks and positions work in java
 *
 * Difficulties:  
 * difficulty understanding at first
 */
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.awt.event.MouseMotionListener;

public class MouseManager implements MouseListener, MouseMotionListener{
	
	private boolean leftPressed, rightPressed;//the two buttons (middle click isnt used in this game)
	private int mouseX, mouseY;//position
	private UIManager uiManager; //for the buttons on screen
	
	public MouseManager(){	}
	
	public void setUIManager(UIManager ui){uiManager = ui;}
	
	@Override
	//handles clicking of the mouse
	public void mousePressed(MouseEvent e) {
		//button 1 is left click
		if(e.getButton() == MouseEvent.BUTTON1)
			leftPressed = true;
		//button 3 is right click
		if(e.getButton() == MouseEvent.BUTTON3)
			rightPressed = true;
	}
	

	@Override
	public void mouseReleased(MouseEvent e) {
		//button 1 is left click
		if(e.getButton() == MouseEvent.BUTTON1)
			leftPressed = false;//it is no longer clicked
		//button 3 is right click
		if(e.getButton() == MouseEvent.BUTTON3)
			rightPressed = false;
		//if there is a UI object, call the mouse release method
		if(uiManager!= null){
			uiManager.onMouseRelease(e);
		}
	}
	@Override
	public void mouseMoved(MouseEvent e) {
		mouseX = e.getX();
		mouseY = e.getY();
		
		if(uiManager!= null){
			uiManager.onMouseMove(e);
		}
	}
	
//overridden methods that aren't used
	@Override
	public void mouseDragged(MouseEvent e) {	}

	@Override
	public void mouseClicked(MouseEvent e) {	}

	@Override
	public void mouseEntered(MouseEvent e) {	}
	
	@Override
	public void mouseExited(MouseEvent e) {		}

	/****ACCESSORS**********/
public boolean isLeftPressed() {return leftPressed;}

public boolean isRightPressed() {return rightPressed;}

public int getMouseX() {return mouseX;}

public int getMouseY() {	return mouseY;}
}

