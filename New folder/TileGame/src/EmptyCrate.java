
/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-9-17
 
 Description:
	 * This class handles all empty crates, when attacked it will spawn nothing
 What I learned:
	 * no new concepts
 Difficulties:  
	 * hard to follow the code when drawing an image
 */
import java.awt.Graphics;

public class EmptyCrate extends Entity {
	public EmptyCrate (Handler handler, float x, float y){
		super(handler, x,y,Tile.TILE_WIDTH, Tile.TILE_HEIGHT);//the dimensions of a tree
	}

	@Override
	public void tick(){}
	@Override
	public void die(){}//when this box is broken, so nothing bc its empty

	@Override
	public void render(Graphics g) {
		g.drawImage(Assets.crate//send the crate asset
				,(int)(x-handler.getGameCamera().getxOffset()),//send the x position 
				(int)(y-handler.getGameCamera().getyOffset()),//send the y position
				width,height,null);//send the width, height, and observer (null)
	}
}
