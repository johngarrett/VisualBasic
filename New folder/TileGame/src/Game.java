/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-9-17
 
 Description:
	 * This class contains almost everything needed to run the game, hold the base code for the game
 What I learned:
	 *how to utilize multiple threads
	 *buffer strategies
	 *how buffered images and graphics work
 Difficulties:  
	 * code gets more and more confusing the more I add
 */

import java.awt.*;
import java.awt.image.BufferStrategy;

 
public class Game implements Runnable{ //'Runnable' allows the game class to run on a thread

	private Display display; //display object
	private int width, height;
	public String title;
	private boolean running = false;
	
	//threads allow applications to run separately
	private Thread thread;
	
	private BufferStrategy bs;
	private Graphics g;
	
	//Input
	private KeyManager keyManager;
	private MouseManager mouseManager;
	
	//States
	public State gameState;
	public State menuState;
	
	//Camera
	private GameCamera gameCamera; 
	
	//Handler 
	private Handler handler;
	public Game(String t, int w, int h)
	{
		width = w;
		height = h;
		title = t;
		keyManager = new KeyManager();//handles the user input
		mouseManager = new MouseManager();
		//handler = new Handler(this);
	}
	
//Initialization method for the game
	private void init()
	{
		display = new Display(title, width, height);//the actual window
		
		display.getFrame().addKeyListener(keyManager);//allows us to access the keyboard
		
	//use the frame and canvas to use whichever window is active (ensures the code will work and not crash)
		display.getFrame().addMouseListener(mouseManager);//for the left and right click
		display.getFrame().addMouseMotionListener(mouseManager);//for the x and y pos of the mouse
		display.getCanvas().addMouseListener(mouseManager);//for the left and right click
		display.getCanvas().addMouseMotionListener(mouseManager);//for the x and y pos of the mouse
		Assets.init();//initalize the assets
		
		handler = new Handler(this);
		gameCamera = new GameCamera(handler, 0,0);//everything is drawn at the normal position first
	//setting the state objects
		gameState = new GameState(handler);
		menuState = new MenuState(handler);
		State.setState(menuState);//initlaize by opening the menu state
	}
		
	
//updates everything for the game
	private void tick(){
		keyManager.tick(); 
		
		if(State.getState() != null)//if the current state actually exists, tick
			State.getState().tick();
	}
	
//this method handles the rendering in the game
	private void render(){
	/*buffer strategy tells the computer how to draw to the screen,
	a buffer is between the code and actual screen*/
		bs = display.getCanvas().getBufferStrategy();//bs = the current buffer strategy
		
	//first time running, create a buffer strategy
		if(bs == null)
			{ display.getCanvas().createBufferStrategy(3);
			return;//break out of the method (find another way to do this)
			}
		
		g = bs.getDrawGraphics();
	//clear the screen (required before drawing)
		g.clearRect(0, 0, width, height);//creates a rectangle the size of the windows, clearing it
		
/*****************************START DRAW*********************************/
		
		if(State.getState() != null)//if the current state actually exists, render
			State.getState().render(g);
		
/*******************************STOP DRAW********************************/
		
		bs.show();
		g.dispose();//clears the graphic object when finished 
	}
	
	public void run(){
		init(); //Initialize the game

		int fps = 60; //limits how many time the tick and render methods are called a second 
		double timePerTick = 1000000000/fps; //1 billion nano seconds in a seconds, we measure time in nanoseconds for this
		double delta = 0;//the amount of time until tick and render must be called again
		long now;//the current time
		long lastTime = System.nanoTime();//the current time of the computer in nanoseconds
		long timer = 0;
		int ticks = 0;//how many times the tick method was called 
		
	//while the game is still running, keep ticking and rendering
		while(running) {
			
			now = System.nanoTime();//the current time
		//tells the computer when and when not to call tick and render methods
			delta+= (now-lastTime)/timePerTick;//the amount of time passed since last call divided by the max amount of time allowed 
			timer += now - lastTime;//the amount of time passed since this code was last called
			lastTime = now;//the last time the block of code was run
		
			if(delta >= 1){//if the time accumulated over 1, then we have to tick and render
				tick(); 
				render();
				ticks++;//count how many times we ticked
				delta--; //subtract 1
			}
			
		//fps counter, print it into the console
			if(timer>= 1000000000){//1 second
			//	System.out.println("Ticks and Frames:"+ticks); used for testing FPS
				ticks = 0;
				timer = 0;
			}
		}
		
		stop();//just in case, stop the thread when the game is over
	}
	
	
	/*synchronized is a keyword used to start and stop threads*/
	public synchronized void start(){
	//this should only be done to start the game
		if(running == false){
			running = true;
			thread = new Thread(this);
			thread.start();//calls the previous run method
		}
	}
	public synchronized void stop()
	{
		if(running == false) return;//if the game is already stopped, do nothing
		running = false;
	//tries to end the thread
		try{thread.join();}
		catch (InterruptedException e){e.printStackTrace();}
	}
	
	//ACCESSORS
	public KeyManager getKeyManager(){return keyManager;}
	public MouseManager getMouseManager(){return mouseManager;}
	public GameCamera getGameCamera(){return gameCamera;}
	
	public int getWidth(){return width;}
	public int getHeight(){return height;}
}
