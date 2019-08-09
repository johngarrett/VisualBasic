 /*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-11-17
 
 Description:
	 * this is a subclass that handles the dirt tile
 What I learned:
 	 * no new concpets here
 Difficulties:  
	 * none
 */
public class DeskTile extends Tile{

	public DeskTile(int i) {super(Assets.desk, i);}
	
	@Override 
	public boolean isSolid() {
		return true;//solid as it should mimick a desk of sorts
	}
}
