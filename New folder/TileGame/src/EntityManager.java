/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-11-17
 *
 * Description:
 * This class manages all the entities in the game
 * What I learned:
 *refreshed my knowledge on iterators 
 *
 * Difficulties:  
 * none other than basic syntax
 */
import java.awt.Graphics;
import java.util.*;

//manages all the entities in the game
public class EntityManager {

	private Handler handler;
	private Player player;
	private ArrayList<Entity> entities;//holds crates
	
	
	//comparing two entities
	private Comparator<Entity> renderSorter = new Comparator<Entity>(){
				public int compare(Entity a, Entity b){
					if(a.getY() + a.getHeight() //if y+the entity height
					< b.getY()+b.getHeight()) //is lower than the other's y+height
						return -1;//it is below, render below
					
					//if its higher up, render it first
					return 1;//if b has a lower y value
				}};
	
	
	
	
	public EntityManager(Handler h, Player p){
		player = p;
		handler = h;
		
		entities = new ArrayList<Entity>();
		addEntity(player);//the player is an entity so render it along with the others
		
	}
	
	public void tick(){
		
	//traverse the entities list for each entity
		Iterator<Entity> it = entities.iterator();
		while(it.hasNext()){//as long as there are items in the iterator...
			Entity e = it.next();//e is the current element being inspected
			e.tick();
			if(!e.isActive())
				it.remove();//remove the entity if it is dead
		}
		entities.sort(renderSorter);
}
	
	
	public void render(Graphics g){
		for(Entity e: entities){//for each traverse 
			e.render(g);
		}
		player.postRender(g);//render the player each time
	}


	public void addEntity(Entity e){
		entities.add(e);//add any passed over entity to the list
	}
	
	
	
	
	/**********GETTERS AND SETTERS****************/
	public Handler getHandler() {return handler;}

	public void setHandler(Handler handler) {this.handler = handler;}

	public Player getPlayer() {return player;}

	public void setPlayer(Player player) {this.player = player;}

	public ArrayList<Entity> getEntities(){ return entities;}

	public void setEntities(ArrayList<Entity> entities) {this.entities = entities;}
}
