
/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-9-17
 
 Description:
	 * This class hold the visible window for the user
 What I learned:
	 * how jFrames and Canvases work
 Difficulties:  
	 * none
 */
import javax.swing.JFrame;//for the window
import java.awt.Canvas;//for the drawings
import java.awt.Dimension;//idk if this is right
public class Display {
	
	private JFrame frame; //used for the window
	private Canvas canvas; //draw all elements to the canvas then display canvas on frame
	
	//JFrame needs a title, width and height
	private String title;
	private int width, height;
	
	public Display(String t, int w, int h)
	{
		//Initialize the vars then create a display
		title = t;
		width = w;
		height = h;
		
		createDisplay();
	}
  //initialize the display
	private void createDisplay()
	{
	//create frame object 
		frame = new JFrame(title);
		frame.setSize(width,height);
		
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);//ensure the program closes on exit
		frame.setResizable(false);//fixes the size of the window
		frame.setLocationRelativeTo(null); //sets the window to open in the center
		frame.setVisible(true);//JFrame, by default, aren't visible
		
	//create the canvas object
		canvas = new Canvas();
		canvas.setPreferredSize(new Dimension(width,height));
		
	//ensure the canvas stays at the preferred size
		canvas.setMaximumSize(new Dimension(width,height));
		canvas.setMinimumSize(new Dimension(width,height));
		canvas.setFocusable(false);//makes sure the JFrame is on top of everything else
		
	//add the canvas to the frame
		frame.add(canvas);
		frame.pack();//resizes the frame to fit
	}
	//getter for canvas
	public Canvas getCanvas(){return canvas;}
	//getter for JFrame
	public JFrame getFrame(){ return frame;}
}
