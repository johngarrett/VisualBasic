/*
 * Program: Final Project
 * Version: 1.0
 * John Garrett
 * 5-15-17
 *
 * Description:
 * This class defines variables and methods used in extended classes
 * What I learned:
 * the function for finding the current time in miliseconds
 * Difficulties:  
 * none
 */


import java.awt.image.BufferedImage;

public class Animation {
	private int speed, index; //the speed of the animation and the index used in the array
	private BufferedImage[] frames;//the "animation" is two images in an array switching back and forth at a fixed interval
	private long lastTime;//the time elapsed since last tick
	private long timer;
	
	public Animation(int s, BufferedImage[] f){
		frames = f;
		speed = s;
		index = 0;
		lastTime = System.currentTimeMillis();//the current time in milliseconds
		timer = 0;
	}
	
//return the current frame of the animation
	public BufferedImage getCurrentFrame(){return frames[index];}
	
	
//this method decides which image should be returned
	public void tick(){
		/*the time elapsed since the last tick,
		keep adding that to the timer var until it surpasses speed*/
		timer += System.currentTimeMillis() - lastTime;
		
		lastTime = System.currentTimeMillis();//reset the lastTime var to the current time
		
		//when times exceeds the speed, increase the index and reset timer
		if(timer>speed){
			index++;
			timer = 0;
			if(index >= frames.length) index = 0;//restart the animation when the last frame is reached
		}
	}
}
