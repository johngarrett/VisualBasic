

/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * this class allows us to pass 1 object that will handle everything
 * 	mainly used to consolidate code and pass objects

 * What I learned:
 * a new way to shorten code
 *
 * Difficulties:  
 * remembering when and how to use this class 
 */

public class Handler {
	private Game game;
	private World world;
	
	public Handler(Game g)
	{
		game = g;	
	}
		
	
	//these ask if the items have been picked up
	public int collected = 0;//how many items were collected
	
	/********ACCESSORS AND MUTATORS(the main point of this class)******/

	public KeyManager getKeyManager(){return game.getKeyManager();}
	
	public GameCamera getGameCamera(){return game.getGameCamera();}

	public int getWidth(){return game.getWidth();}
	
	public int getHeight(){return game.getHeight();}
	
	public MouseManager getMouseManager(){	return game.getMouseManager();}
	
	public Game getGame() {return game;}
	
	public void setGame(Game game) {this.game = game;}
	
	public World getWorld() {return world;}
	
	public void setWorld(World world) {	this.world = world;	}
	
}

