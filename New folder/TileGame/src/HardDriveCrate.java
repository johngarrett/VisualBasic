/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * This class defines and renders a harddrive crate
 * What I learned:
 *no new concepts
 *
 * Difficulties:  
 * none
 */
import java.awt.Graphics;
public class HardDriveCrate extends Entity {
	public HardDriveCrate(Handler handler, float x, float y){
		super(handler, x,y,Tile.TILE_WIDTH, Tile.TILE_HEIGHT);//the dimensions of a crate
	
	}

	@Override
	public void tick() {}
	
	@Override
	public void die()
	{
		//when this box is opened, it produces a harddrive
		handler.getWorld().getItemManager().addItem(Item.hddItem.createNew((int)x,(int)y));
		
	}
	

	@Override
	//by defualt render a crate
	public void render(Graphics g) {
		g.drawImage(Assets.crate,(int)(x-handler.getGameCamera().getxOffset()),(int)(y-handler.getGameCamera().getyOffset()),width,height,null);
		}
}
