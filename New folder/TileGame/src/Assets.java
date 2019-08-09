/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-9-17
 
 Description:
	 * this is only called once
	 * will load in everything for the game
 What I learned:
 	 * how to load in fonts
 	 * how sprite sheets work
 Difficulties:  
	 * determining the location of each sprite in the sheet
 */
import java.awt.*;
import java.awt.image.BufferedImage;

public class Assets {
	//32 x 32 for each sprite in the sprite sheet
	private static final int width = 32, height = 32;//the defualt size of a tile on the sprite sheet
	
	public static Font font28;//28 size font (used for the inventory)
	public static Font caption;//font for the caption
	
	public static BufferedImage desk, concrete, brick,crate, rock, 
	harddrive, monitor, keyboard, ram, graphicsCard; //all the sprites in the game
	
//arrays of animations for the player
	public static BufferedImage[] player_down;
	public static BufferedImage[] player_up;
	public static BufferedImage[] player_left;
	public static BufferedImage[] player_right;
//other images used for the game	
	public static BufferedImage[] btn_start;//for the start button
	public static BufferedImage[] abt_btn;//the about button
	public static BufferedImage[] tut_btn;//the tutorial button
	public static BufferedImage inventoryScreen;//for the inventory
	public static BufferedImage menuBackGround; //for the background of the menu state
	public static BufferedImage winningBackGround;//the background of the winning state
	
	public static void init()
	{
		//load the font 
		font28 = FontLoader.loadFont("res/fonts/slkscr.ttf", 28);
		
		//create a new sprite sheet object based off of the png file in the resources
		SpriteSheet sheet = new SpriteSheet(ImageLoader.loadImage("/textures/sprites.png"));
		
		//initalize the menu background
		menuBackGround = ImageLoader.loadImage("/textures/bg.png");
		//initalize the inventory screen
		inventoryScreen = ImageLoader.loadImage("/textures/inventoryScreen.png");
		//initalize the winning background
		winningBackGround = ImageLoader.loadImage("/textures/GAMEOVER.png");
		
	/*the parameters are where the sprites are on the sheet
	 * 
		ex, player down (animation 1) is over 4, on the first row,
	 	with a defualt width and takes up two boxes vertically*/
		
		//start button
			btn_start = new BufferedImage[2];
			btn_start[0] = sheet.crop (width*4, height *4, width *4, height*2);//unpressed button
			btn_start[1] = sheet.crop (width*4, height *6, width *4, height*2);//pressed button
		//about button
			abt_btn = new BufferedImage[2];
			abt_btn[0] = sheet.crop (0, height *4, width *4, height*2);//unpressed button
			abt_btn[1] = sheet.crop (0, height *6, width *4, height*2);//pressed button
			//about button
			tut_btn = new BufferedImage[2];
			tut_btn[0] = sheet.crop (width*4, height *8, width *4, height*2);//unpressed button
			tut_btn[1] = sheet.crop (width*4, height *10, width *4, height*2);//pressed button
			
		//player
			player_down = new BufferedImage[2];//2 frame animation
			player_up = new BufferedImage[2];//2 frames
			player_left = new BufferedImage[2];//2 frames 
			player_right = new BufferedImage[2];//2 frames 
		//world items
			desk = sheet.crop(width, 0, width, height);
			concrete = sheet.crop(width*2, 0, width, height);
			brick = sheet.crop(width*3, 0, width, height);		
			crate = sheet.crop(0, height * 8, width*2, height*2);
			graphicsCard = sheet.crop(0,height*2, width, height);
			harddrive = sheet.crop(0,height*3,width, height); 
			monitor = sheet.crop(width, height*3, width, height);
			keyboard = sheet.crop(width*2, height*3, width*2, height);
			ram = sheet.crop(width*2, height*2, width,height);//plus 1 on width removes an artifact on sprite sheet

		//down animation (for player)
			player_down[0] = sheet.crop(width*4, 0, width,height*2);
			player_down[1] = sheet.crop(width*5, 0, width,height*2);
		//up animation
			player_up[0] = sheet.crop(width*4, height*2, width,height*2);
			player_up[1] = sheet.crop(width*5, height*2, width,height*2);
		//let animation
			player_left[0] = sheet.crop(width*6, height*2 , width,height*2);
			player_left[1] = sheet.crop(width*7, height*2, width,height*2);
		//right animation
			player_right[0] = sheet.crop(width*6, 0, width,height*2);
			player_right[1] = sheet.crop(width*7, 0, width,height*2);		
	}


	//getter for the backgrounds
	public static BufferedImage getMenuBackGround() {return menuBackGround;}
	public static BufferedImage getWinningBackGround() {return winningBackGround;}
	
}
