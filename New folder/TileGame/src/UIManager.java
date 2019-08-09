

/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * manages all UI Elements in the game (non entities )
		(a lot of mutators and accessors)
 * What I learned:
 * no new concepts
 *
 * Difficulties:  
 * none
 */
import java.awt.Graphics;
import java.awt.event.MouseEvent;
import java.util.*;
public class UIManager {
	private Handler handler;
	private ArrayList<UIObject> objects;//all the UI objects to tick and render

	public UIManager(Handler h){
		handler = h;
		objects = new ArrayList<UIObject>();
	}
	
	
	public void tick(){
		//for each object in objects
		for(UIObject o:objects)
		{
			o.tick();//tick each object
		}
	}
	
	public void render(Graphics g){
		for(UIObject o:objects)
		{
			o.render(g);//render each object
		}
	}
	
	
	public void onMouseMove(MouseEvent e){
		for(UIObject o:objects)
		{
			o.onMouseMove(e);
		}
	}
	
	public void onMouseRelease(MouseEvent e){
		for(UIObject o:objects)
		{
			o.onMouseRelease(e);
		}
	}
	
	/*****MUTATORS AND ACCESSORS**********/
	public Handler getHandler() {return handler;}
	public void setHandler(Handler handler) {this.handler = handler;}

	public ArrayList<UIObject> getObjects() {return objects;}

	public void setObjects(ArrayList<UIObject> objects) {this.objects = objects;}
	public void addObject(UIObject o){objects.add(o);}
	public void removeObject (UIObject o)	{objects.remove(o);	}
}
