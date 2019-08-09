/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 
  Description:
 	* This class loads in the essiental font for the inventory
  What I learned:
 	* how to load in a font
 *
  Difficulties:  
 	* none
 */
import java.awt.Font;
import java.awt.FontFormatException;
import java.io.*;

public class FontLoader {
	public static Font loadFont(String path, float size){
		try{
		//try to create a font based on the path
			return Font.createFont(Font.TRUETYPE_FONT, new File(path)).deriveFont(Font.PLAIN, size);
		}
		//if the file isn't found...
		catch (FontFormatException | IOException e){
			e.printStackTrace();
			System.exit(1);//the game can't run without a font, so exit
		}
		return null;//this method has to return something (it should never reach this line of code)
	}
}
