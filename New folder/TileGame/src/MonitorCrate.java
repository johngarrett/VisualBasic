/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * This class handles the monitor crate
 * What I learned:
 *no new concepts
 *
 * Difficulties:  
 * none
 */import java.awt.Graphics;

public class MonitorCrate extends Entity {

	public MonitorCrate(Handler handler, float x, float y) 
	{super(handler, x, y, Tile.TILE_WIDTH, Tile.TILE_HEIGHT);}

	@Override
	public void tick() {}	
	
	@Override
	//when the crate has been broken
	public void die(){
		handler.getWorld().//get the current world from the handler
		getItemManager().//access the item manager
		addItem(Item.monitorItem.//add a monitor item
				createNew((int)x,(int)y));//at x and y (converted to int because it wont take floats)
	}
	@Override
	//when the item is still in the crate
	public void render(Graphics g) {
		g.drawImage(Assets.crate,//draw a crate
				(int) (x - handler.getGameCamera().getxOffset()),//truncate the decimals. this is the x val
				(int) (y - handler.getGameCamera().getyOffset()),//the y value
				width, height, null);//with these dimensions and no observer
	}
}