

/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * This class handles everything for the inventory
 * What I learned:
 * no new concepts, just advanced previous concepts already known
 *
 * Difficulties:  
 * positioning the inventory
 * Displaying the text correctly
 */
import java.awt.Color;
import java.awt.Graphics;
import java.awt.event.KeyEvent;
import java.util.ArrayList;

public class Inventory {

	//Dimensions for the inventory
		private int invX = 250, invY = 250, //x and y position (roughly the middle of the screen)
				invWidth = 512, invHeight = 384,//height and width
				
			//centering items on the inventory
				//(using addition instead of raw values allows the inventory screen to be moved)
				invListCenterX = invX+171, 
				invListCenterY = invY + invHeight /2 +5,
				invListSpacing = 30, //spacing on the list
			//definition of image in inventory
				invImageX = invX + 388, invImageY = invY+34, //the x and y position of the image
				invImageWidth = 64, invImageHeight = 64,//the dimensions of an image in the inventory
				invCountX = 420+invX, invCountY = 124+invY;//used for placing the text
		
		private int selectedItem = 0; //index of currently selected item
		private Handler handler;
		private boolean active = false;//a toggle boolean used to bring up the inventory
		private ArrayList<Item> inventoryItems;
		
		public Inventory(Handler h){
			handler = h;
			inventoryItems = new ArrayList<Item>();
		}
		
		public void tick(){
			//E is the toggle key
			if(handler.getKeyManager().keyJustPressed(KeyEvent.VK_E))
				active = !active;//invert it
			 
			if(!active)//if active is false, quit the method
				return;
			
			//navigating the inventory list
			if(handler.getKeyManager().keyJustPressed(KeyEvent.VK_W))//if the user hits W
				selectedItem--;//move up one
			
			if(handler.getKeyManager().keyJustPressed(KeyEvent.VK_S))//if the user hits S
				selectedItem++;//move down one
			
			
			if(selectedItem < 0)
				selectedItem = inventoryItems.size() - 1;//loop around
			
			else if (selectedItem >= inventoryItems.size())
				selectedItem = 0;//start at the beginning
			
			
			
		}
		
		public void render(Graphics g){
			//when all the items are collected, end the game
			if(handler.collected >=5)
			{
				//System.out.println("TESTING!");
				State endState = new WinningState(handler);
				State.setState(endState);//set endState to the current state			
			}
			if(!active) return;//if the inventory isnt open, exit this method
			g.drawImage(Assets.inventoryScreen, invX, invY, invWidth, invHeight,null);//dimensions set and declared for the inventory screen
			
			int size = inventoryItems.size();
			if(size == 0)
				return;//exit the method if there are no items to render
			for(int i = -5; i < 6; i++)//5 slots above, 5 slots below on the inventory
			{
				if(selectedItem + i < 0 || selectedItem + i >= size)//if the item is out of bounds of the inventory, just skip that item and continue
					continue; 
				//the selected item (make it yellow)
				if(i == 0)
					Text.drawString(g, ">"+inventoryItems.get(selectedItem+i).getName()+ "<", 
							invListCenterX, invListCenterY + i * invListSpacing, true, Color.YELLOW, Assets.font28);	
				
				//all other items (make them white)
				else 
					Text.drawString(g, inventoryItems.get(selectedItem+i).getName(), //the name of the item
							invListCenterX,//x position
							invListCenterY + i * invListSpacing, //y position (this changes as you scroll)
							true, Color.WHITE, Assets.font28);	
			}
			
			Item item = inventoryItems.get(selectedItem);
			g.drawImage(item.getTexture(), invImageX, invImageY, invImageWidth, invImageHeight, null);
			
			
			Text.drawString(g, Integer.toString(item.getCount()), invCountX, invCountY, true, Color.WHITE, Assets.font28 );
		}
		
		//Inventory Methods
		public void addItem(Item item){
			for(Item i : inventoryItems){	
				//if the item is already in the inventory, increase the count
				if(i.getId() == item.getId())
				{	i.setCount(i.getCount()+item.getCount()); return;//exit the method
				}
			}
				//if the item isn't in the inventory, add it
				inventoryItems.add(item);
				handler.collected++;//increase the collected var
		}
			
		//GETTERS AND SETTERS
		public Handler getHandler() {return handler;}

		public void setHandler(Handler handler) {this.handler = handler;}

		public boolean isActive() {return active;}

	
		  
		
}
