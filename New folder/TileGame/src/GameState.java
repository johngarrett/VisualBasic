/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-11-17
 
 Description:
	 * this is a subclass that handles launching the game
 What I learned:
 	 * how worlds work in games (at least this game)
 Difficulties:  
	 * none
 */
import java.awt.Graphics;
public class GameState extends State {
	
	private World world;
	
	public GameState(Handler handler)
	{
		super(handler);
		world = new World(handler, "res/worlds/world1.txt");//where the file for the world data is
		handler.setWorld(world);
		
	}

	@Override
	public void tick() {
		world.tick();//world ticks before player

	}

	@Override
	public void render(Graphics g) {
		world.render(g);
	}
}
