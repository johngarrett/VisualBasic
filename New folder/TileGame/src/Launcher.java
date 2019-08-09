/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-9-17
 
 Description:
	 * This class is responsible for launching the game
 What I learned:
 	 * no new concepts
 Difficulties:  
	 * none
 */

public class Launcher {

	public static void main(String[] args) {
		Game game = new Game("Computer Collection Game",//title of the window
				900,900);//dimensions of the window
		game.start();
	} 

}
