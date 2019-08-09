

/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * The RAM Crate
 * What I learned:
 *no new concepts
 *
 * Difficulties:  
 * none
 */
import java.awt.Graphics;

public class RamCrate extends Entity {

	public RamCrate(Handler handler, float x, float y) {
		super(handler, x, y, Tile.TILE_WIDTH, Tile.TILE_HEIGHT);
	}

	@Override
	public void tick() {}	
	
	@Override
	//produce a RAM crate when its broken open
	public void die(){
		handler.getWorld().getItemManager().addItem(Item.ramItem.createNew((int)x,(int)y));
	}
	@Override
	public void render(Graphics g) {
		//draw a crate first, then the item once the crate is broken
		g.drawImage(Assets.crate, (int) (x - handler.getGameCamera().getxOffset()), (int) (y - handler.getGameCamera().getyOffset()), width, height, null);
	}

}