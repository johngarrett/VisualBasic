/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * This class handles everything for a graphics card crate on the map
 * What I learned:
 * no new concepts
 *
 * Difficulties:  
 * none
 */
import java.awt.Graphics;
public class GraphicsCardCrate extends Entity {
	
	public GraphicsCardCrate(Handler handler, float x, float y){
		super(handler, x,y,Tile.TILE_WIDTH, Tile.TILE_HEIGHT);//send up the default tile width and height
	}

	@Override
	public void tick() {}
	
	@Override
	public void die()
	{
		//when a box is opened, it produces a graphics card
		handler.getWorld().getItemManager().addItem(Item.graphicsCardItem.createNew((int)x,(int)y));
		
	}
	

	@Override
	public void render(Graphics g) {
		//by default(when its still alive) draw a crate
		g.drawImage(Assets.crate,(int)(x-handler.getGameCamera().getxOffset()),(int)(y-handler.getGameCamera().getyOffset()),width,height,null);
		
	}
}
