/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-11-17
 
 Description:
	 * this is a subclass that handles the menu
 What I learned:
 	 * how to set/use states and UI objects
 Difficulties:  
	 * handling the mouse clicks
 */
import java.awt.Graphics;
public class MenuState extends State
{
	private UIManager uiManager;
	public MenuState(Handler h)
	{
		super(h);
		uiManager = new UIManager(handler);
		handler.getMouseManager().setUIManager(uiManager);
		
	//for the start button 
		uiManager.addObject(new UIImageButton(400,600,128,128, Assets.btn_start,new ClickListener(){
			@Override
			public void onClick() {
				handler.getMouseManager().setUIManager(null);//"turn off" all the buttons on the menustate
				State.setState(handler.getGame().gameState);//start the game when the play button is clicked
			}}));//from the sprite sheet, instance of the class on the fly
	//for the about button
		uiManager.addObject(new UIImageButton(400,400, 128,128, Assets.abt_btn, new ClickListener(){
			@Override
				public void onClick() {
				//print the about information to the console
				System.out.print("*************ABOUT***********"
						+"\nThis game was created by John Garrett for AP Computer Science in May 2017."
						+"\n\nThe following links were used for some of the games sprites. "
						+ "\n(the rest of the sprites were copyright free, found on google)"
						+"\n\nhttp://michaelcummings.net/mathoms/creating-2d-animated-sprites-using-unity-4.3"
						+ "\nhttps://www.spriters-resource.com/game_boy_gbc/pokemongoldsilver/sheet/9120/");
		 }}));
		//for the tutorial button
		uiManager.addObject(new UIImageButton(400,200, 128,128, Assets.tut_btn, new ClickListener(){
			@Override
				public void onClick() {
				//print the about information to the console
				System.out.print("*********************TUTORIAL******************"
						+ "\n\nThe objective of this game is to collect 5 essiental computer"
						+ "\npieces to build a computer. The crates hold the parts, break them and check your inventory"
						+ "\n to track your progress.\n"
						+"\nThe player is controlled by the WASD keys"
						+"\nuse these keys as arrow keys (W is up, S is down, etc.)"
						+ "\n\nTo break the crates, walk above or below one and repitivly press"
						+ "\nthe up or down arrow key to break it open."
						+ "\nWhen broken, walk over the item to pick it up."
						+ "\n\nLastly, to check your inventory, press E.(when in the inventory, used W and S to scroll "
						+ "\n"//incase this is called before the about, add an extra line
						); }}));
		}
	
	
	@Override
	public void tick() {
		uiManager.tick();//tick the buttons on screen
	}

	@Override
	public void render(Graphics g) {
		g.drawImage(Assets.getMenuBackGround(), 0, 0, null);//a screenshot of the game used as the background (render first)
		uiManager.render(g);//render the buttons on the screen
		
	}
	
}

