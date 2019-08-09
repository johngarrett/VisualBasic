
/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-10-17
 
 Description:
	 * this class will contain everything that every entity needs
	 * an entity is everything in this game that is not a tile
 What I learned:
	 * how jFrames and Canvases work
 Difficulties:  
	 * none
 */
import java.awt.Graphics;
import java.awt.Rectangle;

public abstract class Entity {
	
	protected float x,y;//classes that extends, get this var too. float is used to make a smooth movement
	protected int width, height;
	protected Rectangle bounds;//collision bounds
	protected Handler handler;
	protected int health;//every entity has a health
	protected boolean active = true;//is the entity active?(on the screen)


	public Entity(Handler hand, float x, float y, int w, int h)
	{
		this.x = x;
		this.y = y;
		width  = w;
		height = h; 
		handler = hand;
		health = 3;//three hits and its dead
		
		bounds = new Rectangle(0,0,width, height);//the bound for collision, top left corner of entity to the width and height
		
	}
	
//every entity needs a.....
	public abstract void tick();
	public abstract void render(Graphics g);
	public abstract void die();
	public void hurt(int amt){
		health -= amt;//handles attacks
		if(health <=0){
			active = false; //if the heath is less than or equal to zero, kill the entity 
			die();}
	}
	
	public Rectangle getCollisionBounds(float xOffset, float yOffset){
		//the area around the current entity. the xOffset and yOffset 
		return new Rectangle((int)(x+bounds.x+xOffset), (int)(y+bounds.y+yOffset), bounds.width, bounds.height);
		
	}
	
	public boolean checkEntityCollisions(float xOffset, float yOffset){
		
		//for each loop through all the entities in the manager
		for(Entity e: handler.getWorld().getEntityManager().getEntities()){
			if(e.equals(this)){}//ensures we dont check an entity against its self
			else if(e.getCollisionBounds(0f,0f).intersects(getCollisionBounds(xOffset, yOffset)))
				return true;//there was a collision
			
		}
		return false;
	}
	
	/***********ACCESSORS AND MUTATORS**************/
	public float getX() {return x;}
	
	public int getHealth() {return health;}

	public void setHealth(int health) {this.health = health;}

	public boolean isActive() {return active;}

	public void setActive(boolean active) {this.active = active;}

	public void setX(float x) {this.x = x;}
	
	public float getY() {return y;}
	
	public void setY(float y) {this.y = y;}
	
	public int getWidth() {return width;}
	
	public void setWidth(int width) {this.width = width;}
	
	public int getHeight() {return height;}
	
	public void setHeight(int height) {this.height = height;}
}
