/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-11-17
 
 Description:
	 * this class handles everything for the game camera
 What I learned:
 	 * how a game camera works
 Difficulties:  
	 * the math
 */
public class GameCamera {
	private float xOffset, yOffset;//x offset moves the tiles x units (for the camera)
		//how far off we draw something from its original position
	
	private Handler handler;
	public GameCamera(Handler h, float xo, float yo){
		xOffset = xo;
		yOffset = yo;
		handler = h;
	}
	//see if any blank space is seen on the screen
	//this method basically draws a box around the map, ensuring the camera doesnt pan off the map
	public void checkBlankSpace()
	{
		//left 
		if(xOffset < 0) xOffset = 0;
		//right
		else if(xOffset > handler.getWorld().getWidth() * Tile.TILE_WIDTH - handler.getWidth())//convert to pixels
			xOffset = handler.getWorld().getWidth() * Tile.TILE_WIDTH - handler.getWidth();
		//top
		if(yOffset <0) yOffset = 0;
		//bottom
		else if(yOffset > handler.getWorld().getHeight() * Tile.TILE_HEIGHT - handler.getHeight())
			yOffset = handler.getWorld().getHeight() * Tile.TILE_HEIGHT - handler.getHeight();
	}
	
	//center the camera on the entity chosen (like the player)
	public void centerOnEntity(Entity e){
		xOffset = e.getX() - handler.getWidth() / 2+(e.getWidth()/2);;//center the player
		yOffset = e.getY() - handler.getHeight() / 
				2+(e.getHeight()/2);//this ensures it centers on the middle of the entity
		
		checkBlankSpace();
	}
	public void move(float xAmt, float yAmt){
		xOffset+= xAmt;
		yOffset += yAmt;
		checkBlankSpace();
	}
	
	/****GETTERS AND SETTERS***********/
	public float getxOffset() {return xOffset;}

	public void setxOffset(float xOffset) {this.xOffset = xOffset;}

	public float getyOffset() {return yOffset;}

	public void setyOffset(float yOffset) {this.yOffset = yOffset;}
	
}
