/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-9-17
 
 Description:
	 * This class is designed to contain the basic info every player has
	 * player is-a creature
 What I learned:
	 * no new concepts, just new ways to utilize old ones
 Difficulties: 
	 * the player moves well at first but as time progresses, the controls get worse
	 * 	i need to work on this
	 * adjusting the sprite sheet screws up all of the hitboxes  
 */
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;
import java.awt.image.BufferedImage;

public class Player extends Creature{
	
	//Animations
	private Animation animDown;
	private Animation animUp;
	private Animation animRight;
	private Animation animLeft;
	
	//Attacks
	private long lastAttackTimer, attackCooldown = 800, //wait 800 miliseconds to attack again
			attackTimer = attackCooldown; 
	//Inventory
	private Inventory inventory;
	
	public Player(Handler handler, float x, float y) {
		
		super(handler, x, y,Creature.DEFUALT_CREATURE_WIDTH, Creature.DEFAULT_CREATURE_HEIGHT);
		
	//the collision hit box of the player, numbers were derrived by guess and check
		bounds.x = 16;//16 pixels to the left of the player
		bounds.y = 44;//44 pixels down from the player x
		bounds.width = 32;
		bounds.height = 60;
		
	//animatinos
		animDown = new Animation(250, Assets.player_down);//every 250 miliseconds(quarter second) 
		animUp = new Animation(250, Assets.player_up);
		animLeft = new Animation(250, Assets.player_left);
		animRight = new Animation(250, Assets.player_right);
		
		inventory = new Inventory(handler);

	}
	
	@Override
	/*
	 * this gets the input from the keyboard then tells the player to move
	 */
	public void tick() {
		//Animatinos
		animDown.tick();
		animLeft.tick();
		animUp.tick();
		animRight.tick();

		//Movement 
		getInput();
		move();
		handler.getGameCamera().centerOnEntity(this);//send the player over to be centered
		
		//Attack
		checkAttacks();
		
		//Inventory
		inventory.tick();
	}
	
	private void checkAttacks(){
		attackTimer+= System.currentTimeMillis() - lastAttackTimer;
		lastAttackTimer = System.currentTimeMillis();
		if(attackTimer < attackCooldown) return; //exit
		
		if(inventory.isActive()) return; //the player cant attack when the invetory is active
		
		
		
		
		Rectangle cb = getCollisionBounds(0,0);//colisioin box of the player
		Rectangle ar = new Rectangle(); //attack range
		//if the player is within 20 pixels of the entity and hits attack, it will work
		int arSize = 20;//the size of the attack rectangle
		ar.width = arSize;
		ar.height = arSize;
		
		//draw just above the collision bounds 
		if(handler.getKeyManager().aUp){
			ar.x = cb.x + cb.width/2 - arSize / 2;//this math makes it cented
			ar.y = cb.y - arSize;
		}
		//test below the collision bounds
		else if(handler.getKeyManager().aDown){
			ar.x = cb.x + cb.width/2 - arSize / 2;
			ar.y = cb.y + cb.height;//makes it at the bottom
		}
		//test to the right of the collision bounds
		else if(handler.getKeyManager().aRight){
			ar.x = cb.x + - arSize;//to the left
			ar.y = cb.y + cb.height / 2 - arSize / 2;
		}
		//test to the left of the colision bounds
		else if(handler.getKeyManager().aLeft){
			ar.x = cb.x + cb.width;
			ar.y = cb.y + cb.height /2 - arSize / 2;
		}
		//if the player isnt attacking at all
		else{return;}//exit the method
		
		attackTimer = 0;
		
		//for each entity, check
		for(Entity e: handler.getWorld().getEntityManager().getEntities()){
			if(e.equals(this)){}//if the current entity is the player, keep going
			else{
				if(e.getCollisionBounds(0,0).intersects(ar)){
					e.hurt(1);//hurt the entity with the value of 1
					return;//after an entity is hurt, stop
				}
			}
		}
	}
	
	
	
	@Override
	public void die(){}//System.out.println("You lose");}
	
	/*
	 * this sets the xMove and yMove values to the correct values
	 */
	private void getInput()
	{
		//exit the method if the inventory is open so the user cant move in the background
		if(inventory.isActive())
			return;
		xMove = 0;
		yMove = 0;
		
		if(handler.getKeyManager().up) yMove = -speed; //y moves up 
		if(handler.getKeyManager().down) yMove = speed; //y moves down 
		if(handler.getKeyManager().left) xMove = -speed; //x moves up 
		if(handler.getKeyManager().right) xMove = speed; //x moves down
		
	}
	
	@Override
	//drawing the player
	public void render(Graphics g) {
		g.drawImage(getCurrentAnimationFrame(), (int)(x-handler.getGameCamera().getxOffset()), 
				(int)(y-handler.getGameCamera().getyOffset()) ,width, height*2, null);//draw image method doesnt accept float vars
	}
	//when this method is called, everying else has already been caleed
	public void postRender(Graphics g){
		inventory.render(g);
	}
	
	private BufferedImage getCurrentAnimationFrame(){
		//moving left
		if(xMove < 0)return animLeft.getCurrentFrame();
		
		//moving right
		else if(xMove > 0) return animRight.getCurrentFrame();
		
		//moving up
		else if(yMove < 0) return animUp.getCurrentFrame();
		//moving down
		else return animDown.getCurrentFrame();
		
	}
//ACCESSOR & MUTATOR FOR INVENTORY
	public Inventory getInventory() {return inventory;}

	public void setInventory(Inventory inventory) {	this.inventory = inventory;	}

	

}
