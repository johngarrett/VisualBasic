/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-9-17
 
 Description:
	 * This class loads images from the resources folder
 What I learned:
	 * how to add a resources folder to a project
 Difficulties: 
	 * none 
 */
import java.awt.image.BufferedImage;
import java.io.IOException;//handles the error if the image can't be loaded

import javax.imageio.ImageIO;
public class ImageLoader {
	
		 /*
		  * buffered image is how java stores images
		  * the string path parameter is where the image is located
		  * 
		  */
	public static BufferedImage loadImage(String path){
			try{
				return ImageIO.read(ImageLoader.class.getResource((path)));//load the image in the specified path
			} 
			
			catch (IOException e){
				e.printStackTrace();
				System.exit(1);//exit the game if the image doesn't load
			}
		return null;//java requires a return (this line will never be reached)
		}
}
