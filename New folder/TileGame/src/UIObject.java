

/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * This class effects all the UI Buttons
 * What I learned:
 * a better understanding of mouse events
 *
 * Difficulties:  
 * none
 */
import java.awt.Graphics;
import java.awt.Rectangle;
import java.awt.event.MouseEvent;

//hold all the core components for the UI
public abstract class UIObject {
	protected float x,y;//position
	protected int width, height;//dimensions
	protected boolean hovering = false;//is the mouse inside the object?
	protected Rectangle bounds; //the hit box
	

	public UIObject (float x, float y, int w, int h){
		this.x = x;
		this.y = y;
		width = w;
		height = h;
		bounds = new Rectangle ((int)x, (int)y,width, height);//bounding rectangle is the same size of the button
	}
	
	public abstract void tick();
	public abstract void render(Graphics g);
	public abstract void onClick();
	
//detect if the users mouse is hovering over the object
	public void onMouseMove(MouseEvent e){
		//if the mouse is within the objects bounds
		if(bounds.contains(e.getX(), e.getY()))
			hovering = true;
		
		else hovering = false;
	}
	public void onMouseRelease(MouseEvent e){
		//if the UI object has been clicked or not
		if(hovering)
			onClick();//click if the user is hovering and released a click
	}
	
	//getters and setters
	public float getX() {return x;}
	public void setX(float x) {	this.x = x;}

	public float getY() {	return y;}
	public void setY(float y) {	this.y = y;}

	public int getWidth() {	return width;}
	public void setWidth(int width) {this.width = width;}
	public int getHeight() {	return height;}
	public void setHeight(int height) {this.height = height;}
	
	public boolean isHovering() {return hovering;}
	public void setHovering(boolean hovering) {	this.hovering = hovering;}

}
