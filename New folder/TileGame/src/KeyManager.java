import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-9-17
 
 Description:
	 * This class manages the key input
	 * Key listener allows us to access the keyboard(thus we implement it)
 What I learned:
	 * how key events (other than something like a scanner object) work
 Difficulties: 
	 * i need to improve the speed of the input 
 */
public class KeyManager implements KeyListener {

	private boolean[] keys; //stores all the keys
	private boolean[] justPressed, cantPress;//toggle arrays 
	public boolean up, down, left, right; //if these are true, move in this direction
	
	public boolean aUp, aDown, aLeft, aRight;//attack buttons
	
	
	public KeyManager(){
		keys = new boolean[256];//each key has a key code, this holds all the usable key codes
		justPressed = new boolean [keys.length];//ensures all the arrays are the same size
		cantPress = new boolean [ keys.length];
	
	
	}
	
	public void tick()
	{ 

		//loop through every possible key code
		for(int i = 0; i < keys.length; i++){
			if(cantPress[i] && !keys[i])
				cantPress[i] = false; //allows them to press it again
			
		//if they just pressed it
			else if (justPressed[i])
			{
				cantPress[i] = true;//we dont want them to press it until they release the key
				justPressed[i] = false;
			}
			if(!cantPress[i] && keys[i]){justPressed[i] = true;}//if you are able to press a key and the key i
		}
		
				
	//wasd are the arrow keys in this game, if the key is pushed, these vars are true
		up = keys[KeyEvent.VK_W];
		down = keys[KeyEvent.VK_S];
		left = keys[KeyEvent.VK_A];
		right = keys[KeyEvent.VK_D];
	//these keys handle attacking
		aUp = keys[KeyEvent.VK_UP];
		aDown = keys[KeyEvent.VK_DOWN];
	}
	
	
	public boolean keyJustPressed(int keyCode){
		if(keyCode < 0 ||  keyCode >= keys.length)
			return false;//not a real key
		//if it is a real key, then see if it was just pressed or not
		else return justPressed[keyCode];
	}
	@Override
	public void keyTyped(KeyEvent e) {}

	@Override
	public void keyPressed(KeyEvent e) {
	//if the key sent is out of bounds, exit the method
		if(e.getKeyCode() < 0 ||  e.getKeyCode() >= keys.length)
			return;
	//if not, they did press it
		keys[e.getKeyCode()] = true;
		//System.out.print("Pressed"); used for testing key inputs
	}

	@Override
	//the key is no longer being pressed
	public void keyReleased(KeyEvent e) {
		//if the key sent is out of bounds, exit the method
		if(e.getKeyCode() < 0 ||  e.getKeyCode() >= keys.length)
			return;
		keys[e.getKeyCode()] = false;
	}
	

}
