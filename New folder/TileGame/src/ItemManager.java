/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * This class aims to manage the items on screen
 * What I learned:
 *no new concpets
 *
 * Difficulties:  
 * none
 */
import java.awt.Graphics;
import java.util.ArrayList;
import java.util.Iterator;

public class ItemManager {
	private Handler handler;
	private ArrayList<Item> items;//a list of the items
	
	public ItemManager(Handler h){
		handler = h;
		items = new ArrayList<Item>();
	}
	
	
	public void tick(){
		Iterator<Item> it = items.iterator();
		//traverse the entire items arraylist
		while(it.hasNext()){
			Item i = it.next();//current item
			i.tick();//tick the current item
		//if the item is picked up, remove it from the screen
			if(i.isPickedUp()) 
				it.remove();}
	}
	
	public void render(Graphics g){
		for(Item i : items)
			i.render(g);//use the items x and y posisitions 
	}
	
	public void addItem(Item i){
		i.setHandler(handler);//by default, its null
		items.add(i);}
	
	//getters are setters 
	public Handler getHandler() {return handler;}
	
	public void setHandler(Handler handler) {this.handler = handler;}
	
	public ArrayList<Item> getItems() {return items;}
	
	public void setItems(ArrayList<Item> items) {this.items = items;}

}
