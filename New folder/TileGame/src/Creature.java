
/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-9-17
 
 Description:
	 * This class creates the skeleton for the creature
	 * 	it mainly applies to the player now but could be used for enemies later on
 What I learned:
	 * the benefits of float and protected vars
	 * how to check for collisions
	 * 
 Difficulties:  
	 *  using items from other classes took some digging up
 */

public abstract class Creature extends Entity {//a creature is a type of entity
		public static final int DEFUALT_CREATURE_WIDTH = 64, DEFAULT_CREATURE_HEIGHT = 64;//defualt dimensions
	
	protected float speed; 
	protected float xMove, yMove; //where to move on the x and y axis
	
	public Creature (Handler hand, float x, float y, int w, int h)
	{
		super(hand, x,y, w,h); //send the position & dimensions to the class above
		
		speed = 3.5f;//3.5f is the default speed
		xMove = 0; //Initialize to 0
		yMove = 0;
	}
	
	/*allows the creature to move.
	if the player moves left and right, check and see where the player is moving to
	if they arent going to hit anything, allow them to move*/
	public void move(){
		if(!checkEntityCollisions(xMove, 0f))//left and right
			moveX();
		if(!checkEntityCollisions(0f, yMove))//up and down
			moveY();
	}
	
	public void moveX(){
		
		if(xMove > 0){//Moving right
			//divided by tile width to convert from pixel units to tile units (tx = temporary X)
			int tx = (int) (x + xMove + bounds.x + bounds.width) / Tile.TILE_WIDTH;//the right most side of the box
			
			//if the entity isn't hitting anything, allow it to move
			if(!collisionWithTile(tx, (int) (y + bounds.y) / Tile.TILE_HEIGHT) &&//the upper right of the bounds box
					!collisionWithTile(tx, (int) (y + bounds.y + bounds.height) / Tile.TILE_HEIGHT)){//bottom right
				x += xMove;}
			
			else{x = tx * Tile.TILE_WIDTH - bounds.x - bounds.width - 1;//don't allow them to move
			}
		//the rest of the statements follow a similar structure from above
		}else if(xMove < 0){//Moving left
			int tx = (int) (x + xMove + bounds.x) / Tile.TILE_WIDTH;
			
			if(!collisionWithTile(tx, (int) (y + bounds.y) / Tile.TILE_HEIGHT) &&
					!collisionWithTile(tx, (int) (y + bounds.y + bounds.height) / Tile.TILE_HEIGHT)){
				x += xMove;
			}else
				x = tx * Tile.TILE_WIDTH + Tile.TILE_WIDTH - bounds.x;	
		}
	}
	
	public void moveY(){
		if(yMove < 0){//Up
			int ty = (int) (y + yMove + bounds.y) / Tile.TILE_HEIGHT;
			
			if(!collisionWithTile((int) (x + bounds.x) / Tile.TILE_WIDTH, ty) &&
					!collisionWithTile((int) (x + bounds.x + bounds.width) / Tile.TILE_WIDTH, ty)){
				y += yMove;
				
			}else{y = ty * Tile.TILE_HEIGHT + Tile.TILE_HEIGHT - bounds.y;}
			
		}else if(yMove > 0){//Down
			
			int ty = (int) (y + yMove + bounds.y + bounds.height) / Tile.TILE_HEIGHT;
			
			if(!collisionWithTile((int) (x + bounds.x) / Tile.TILE_WIDTH, ty) &&
					!collisionWithTile((int) (x + bounds.x + bounds.width) / Tile.TILE_WIDTH, ty)){
				y += yMove;
				
			}else{y = ty * Tile.TILE_HEIGHT - bounds.y - bounds.height - 1;}
		}
	}
	//return true if the creature hit a tile that cannot be walked over
	protected boolean collisionWithTile(int x, int y){
		return handler.getWorld().getTile(x, y).isSolid();//isSolid is a boolean method determining if the tile is solid or not
	}
	
	/************ACCESSORS AND MUTATORS***/
	public int getHealth() {return health;	}
	public void setHealth(int health) {this.health = health;}
	
	public float getSpeed() {return speed;}
	public void setSpeed(float speed) {this.speed = speed;}
	
	public float getxMove() {return xMove;	}
	public void setxMove(float xMove) {	this.xMove = xMove;}
	
	public float getyMove() {return yMove;}
	public void setyMove(float yMove) {	this.yMove = yMove;}
	
}
