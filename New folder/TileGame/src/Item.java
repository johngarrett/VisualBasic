
/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * This class creates all the items  
 * 	(and text used for the inventory)
 * What I learned:
 *	bettered my knowledge on buffered Images and rectangles
 *
 * Difficulties:  
 * throughout development, i've changed the spites a lot and renaming/redefining has been a pain
 */
import java.awt.Graphics;
import java.awt.Rectangle;
import java.awt.image.BufferedImage;

public class Item{
	
	//stores 1 instance of every item in the game
	public static Item[] items = new Item[5];//5 items to build a computer in this game
	public static Item hddItem = new Item(Assets.harddrive, "Harddrive", 0);
	public static Item monitorItem = new Item(Assets.monitor, "Monitor", 1);	
	public static Item keyboardItem = new Item(Assets.keyboard, "Keyboard", 2);	
	public static Item ramItem = new Item(Assets.ram, "RAM", 3);	
	public static Item graphicsCardItem = new Item(Assets.graphicsCard, "Graphics Card", 4);	
	
	public static final int ITEM_WIDTH = 32, ITEM_HEIGHT = 32;//defualt size (a tile's size)
	
	protected Handler handler;
	protected BufferedImage texture;//what to draw
	protected String name;
	protected final int id;//each item has its own identification
	
	protected Rectangle bounds; //pick up box
	
	protected int x,y,
	count;//the amount of items in the item instance 
	
	protected boolean pickedUp = false;//if the item has been picked up 
	
	public Item(BufferedImage t, String n, int id)
	{
		bounds = new Rectangle(x,y,ITEM_WIDTH,ITEM_HEIGHT);//the bounds of the item
		this.id = id;
		texture = t;
		name = n;
		count = 1;
		items[id] = this;
	}
	
	public void tick(){
		//if the player overlaps with the item, pick it up
		if(handler.getWorld().getEntityManager().getPlayer().getCollisionBounds(0f,0f).intersects(bounds)){
			pickedUp = true;
			handler.getWorld().getEntityManager().getPlayer().getInventory().addItem(this);//add the item to the inventory
		}
	
	}
	public boolean isPickedUp() {
		return pickedUp;
	}

	//over loading
	//items that are laying on the ground
	public void render(Graphics g){
		if(handler != null)//ensures an error will not be thrown
		render(g,(int)(x -handler.getGameCamera().getxOffset()), (int)(y - handler.getGameCamera().getyOffset()));//call the below method with the x and y of this item 
	}
	
	
	//a specfifc spot in the inventory
	public void render(Graphics g, int x, int y){
		g.drawImage(texture,x,y,ITEM_WIDTH, ITEM_HEIGHT, null);
	}
	
	public void setPosition(int x, int y){
		this.x = x;
		this.y = y;
		bounds.x = x; bounds.y = y;
	}
	
	public Item createNew(int x, int y){
		//creates a copy of the item class
		Item i = new Item(texture, name, id);
		i.setPosition(x,y);//the position sent over
		return i;
	}
	//for testing and debugging
//	public Item createNew(int count){
//		//creates a copy of the item class
	//	Item i = new Item(texture, name, id);
//		i.setPickedUp(true);
	//	i.setCount(count);
//		return i;
	//}
	
//GETTERS AND SETTERS
	public Handler getHandler() {	return handler;}

	public void setHandler(Handler handler) {this.handler = handler; }
	
	public BufferedImage getTexture() { return texture; }

	public void setTexture(BufferedImage texture) {	this.texture = texture;	}

	public String getName() {	return name;}
	
	public void setPickedUp(boolean pickedUp) {this.pickedUp = pickedUp;}

	public void setName(String name) {	this.name = name;}

	public int getX() {	return x;}

	public void setX(int x) {	this.x = x;}

	public int getY() {	return y;}

	public void setY(int y) {	this.y = y;}
	
	public int getCount() {	return count;}
	
	public void setCount(int count) {	this.count = count;}

	public int getId() {	return id;}
}
