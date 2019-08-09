import java.awt.Graphics;
import java.awt.image.BufferedImage;
/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-11-17
 
 Description:
	 * this is the base class for every single tile
 What I learned:
 	 * no new concpets here
 Difficulties:  
	 * none
 */
public class Tile {
	//STATIC VARS
	public static Tile[] tiles = new Tile[600];//an arbitrary number
	public static Tile concreteTile = new ConcreteTile(0);//the id num 0 is now always 0
	public static Tile deskTile = new DeskTile(1);
	public static Tile brickTile = new BrickTile(2);

	
	//CLASS
	public static final int TILE_WIDTH = 64, TILE_HEIGHT = 64;//each tile is twice the size of its sprite
	protected BufferedImage texture;
	protected final int id;//the identification number should not change
	
	public Tile(BufferedImage t, int i)
	{
		texture = t;
		id = i;
		
		tiles[id] = this; //this class right here 
	}
	
	public void tick(){}
	
	public void render(Graphics g, int x, int y)//x and y is pos
	{
		g.drawImage(texture,x,y,TILE_WIDTH, TILE_HEIGHT, null);//draw the tile at x and y with the specified width and height
	}
	
	//the tile is walkable if this is false
	public boolean isSolid(){return false;}
	
	//accessor
	public int getId(){return id;}
}
