

/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * This class defines the keyboard crate
 * What I learned:
 *no new concepts
 *
 * Difficulties:  
 * none
 */
import java.awt.Graphics;

public class KeyBoardCrate extends Entity {

	public KeyBoardCrate(Handler handler, float x, float y)
	//send these vars up the the static entity class
	{super(handler, x, y, Tile.TILE_WIDTH, Tile.TILE_HEIGHT);}

	@Override
	public void tick() {}
	
	@Override
	//when the keyboard crate is destroyed, render a keyboard
	public void die(){
		handler.getWorld().getItemManager().addItem(Item.keyboardItem.createNew((int)x,(int)y));
	}

	@Override
	public void render(Graphics g) {
		//draw a crate first, then the item once the crate is broken
		g.drawImage(Assets.crate, (int) (x - handler.getGameCamera().getxOffset()), (int) (y - handler.getGameCamera().getyOffset()), width, height, null);
	}

}