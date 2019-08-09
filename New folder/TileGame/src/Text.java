

/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * This class handles drawing text
 * What I learned:
 * well, how to draw text
 *
 * Difficulties:  
 * the various methods and math involved 
 */import java.awt.Color;
import java.awt.Font;
import java.awt.FontMetrics;
import java.awt.Graphics;

public class Text {
	public static void drawString(Graphics g, String text, int xPos, int yPos, boolean center, Color c, Font font)
	{
		g.setColor(c);//the color passed over, draw the text with that color
		g.setFont(font);
		int x = xPos;
		int y = yPos;
		
		//if the text needs to be centered (for the inventory)
		if(center){
			FontMetrics fm = g.getFontMetrics(font);//pass in the sent font
			x = xPos - fm.stringWidth(text) / 2;//the position passed in minus the width of the text / 2
			y = (yPos - fm.getHeight() / 2) + fm.getAscent();
		}
		
		g.drawString(text, x, y);//draw the text
	}
}
