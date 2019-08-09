/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-9-17
 
 Description:
	 * this class creates sprites for the game
	 * a sprite sheet is all the images wanted in one picture
	 * this class splits all of the sub images up
 What I learned:
 	 * how to create sprites from a given image and specification 
 Difficulties:  
 	 * none 
 */

import java.awt.image.BufferedImage;


public class SpriteSheet {
	private BufferedImage sheet;//the obejct for the sprite sheet
	
//pass an image in
	public SpriteSheet(BufferedImage s){sheet = s;}
		
	/*
	 * returns the cropped image
	 * x & y defines where to start
	 */
	public BufferedImage crop(int x, int y, int w, int h)
	{
		return sheet.getSubimage(x, y, w, h);//returns an image of the specified sprite 
	}
}
