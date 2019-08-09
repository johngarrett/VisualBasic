

/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * This class is for all buttons in the ui (on the menu state)
 * What I learned:
 * no new concepts
 * Difficulties:  
 * none
 */
import java.awt.Graphics;
import java.awt.image.BufferedImage;

public class UIImageButton extends UIObject {

	private BufferedImage[] images;//index 0 is regular, index 1 is the hover image
	private ClickListener clicker;//waiting for a mouse click
	
	public UIImageButton(float x, float y, int w, int h, BufferedImage[] i, ClickListener c) {
		super(x, y, w, h);
		images = i;
		clicker = c;
	}

	@Override
	public void tick() {		}

	@Override
	public void render(Graphics g) {
		if(hovering)
			g.drawImage(images[1],(int)x,(int)y,null);//the hovering image
		else 
			g.drawImage(images[0],(int)x,(int)y,null);//the non hovering image

	}

	@Override
	public void onClick() {
		clicker.onClick();
	}

}
