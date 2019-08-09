
/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-11-17
 
 Description:
	 * this is a subclass that handles the brick tile
 What I learned:
 	 * no new concepts here
 Difficulties:  
	 * none
 */

public class BrickTile extends Tile{

	public BrickTile(int i) {super(Assets.brick, i);}
	
	@Override 
	public boolean isSolid() {
		return true;//the brick tile is solid, an entity cannot walk over it
	}

}
