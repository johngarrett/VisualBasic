import java.awt.Graphics;

/*
 * Final Project
 * Version: 1.0
 * John Garrett
 * 5-11-17
 
 Description:
	 * this handles everything for the world
	 * 		
 What I learned:
 	 * no new concpets here
 Difficulties:  
	 * none
 */
public class World {
	private Handler handler;
	private int width, height; //the size of the map (tiles by tiles)
	private int spawnX, spawnY;//where the player spawns originally
	private int[][] tiles; //full of tile IDs
	
	//Entities
	private EntityManager entityManager;
	//Item
	private ItemManager itemManager;
	public World(Handler h, String path)
	{
		handler = h;
		entityManager = new EntityManager(handler, new Player(handler,100,100));
		itemManager = new ItemManager(handler);
		

		// adding entities to the world (orignally measured for 32x32 crates... *2 to make it 64 x 64)
				entityManager.addEntity(new HardDriveCrate(handler, 192*2, 32*2));
				entityManager.addEntity(new MonitorCrate(handler, 544*2, 32*2));
				entityManager.addEntity(new KeyBoardCrate(handler, 480*2, 384*2));
				entityManager.addEntity(new RamCrate(handler, 384*2, 128*2));
				entityManager.addEntity(new GraphicsCardCrate(handler, 192*2, 544*2));
				
				//empty crates
				//entityManager.addEntity(new EmptyCrate(handler, 192*2, 576*2));
				//entityManager.addEntity(new EmptyCrate(handler, 384*2, 160*2));
				entityManager.addEntity(new EmptyCrate(handler, 384*2, 480*2));
				entityManager.addEntity(new EmptyCrate(handler, 66*2, 352*2));

		//spawn the player in based on the speficiations in the file
		loadWorld(path);

		entityManager.getPlayer().setX(spawnX);
		entityManager.getPlayer().setX(spawnY);
		

	}
	//getter and setter for entity manager
	public EntityManager getEntityManager() {
		return entityManager;
	}

	public void setEntityManager(EntityManager entityManager) {
		this.entityManager = entityManager;
	}

	public void tick(){
		itemManager.tick();
		entityManager.tick();
	}
	
	public void render(Graphics g){
		//limit to draw the visible tiles only
		
		//the math.max ensures that it doesnt go negative, start at either 0 or the calcuation
		int xStart = (int)Math.max(0, handler.getGameCamera().getxOffset() / Tile.TILE_WIDTH); //tile on the left the user can see
		//either render to the width or the xOffset+the game width because we are looking at the far right not the far left (not 0, the width) / tilewidth
		int xEnd = (int)Math.min(width, (handler.getGameCamera().getxOffset()+handler.getWidth()) /Tile.TILE_WIDTH+1); //add 1 so it renders a little better
		
		
		int yStart =(int)Math.max(0, handler.getGameCamera().getyOffset() / Tile.TILE_HEIGHT); //top
		int yEnd =  (int)Math.min(height, (handler.getGameCamera().getyOffset()+handler.getHeight()) /Tile.TILE_HEIGHT+1);;//bottom
		
		
		for(int y = yStart; y< yEnd; y++){
			for(int x = xStart; x< xEnd; x++){
				
				getTile(x,y).render(g,(int)(x*Tile.TILE_WIDTH - handler.getGameCamera().getxOffset()),
						(int)(y*Tile.TILE_HEIGHT-handler.getGameCamera().getyOffset()));//stretches the tile to the correct size
			}
		}
		//render items
		itemManager.render(g);
		//render entity
		entityManager.render(g);
	}
	
	//find the ID at the specified location
	public Tile getTile(int x, int y)
	{
		if(x < 0|| y< 0 || x>= width || y>= height)//if their is a glitch and an entity leabs the map boundaries
			return Tile.concreteTile;//treat the entity as if it were standing on a concrete tile
		Tile t = Tile.tiles[tiles[x][y]];
		if(t == null) return Tile.deskTile; //if there is no ID set in the position
		return t; 
	}
	
	//loads the world from the file (path)
	private void loadWorld(String path){
		String file = Utils.loadFileAsString(path);
		String[] tokens = file.split("\\s+");//all the numbers in the file, split at every space
		width = Utils.parseInt(tokens[0]);//the first number in the file is the width
		height = Utils.parseInt(tokens[1]);//the second number in the file is the height
		
		spawnX = Utils.parseInt(tokens[2]);//the 1st number on the second line is the x
		spawnY = Utils.parseInt(tokens[3]);//followed by the y
		
		
		//every number after those ^ is the world date (which tiles to display)
		tiles = new int[width][height];
		
		for(int y = 0; y< height; y++)
		{
			for(int x = 0; x <width; x++)
			{
				//the first 4 values in the tokens array arent useful for the map
				tiles[x][y] = Utils.parseInt(tokens[(x+y*width+4)]);//converts the 2d array x and y into a 1d arrray
			}
		}
		
	}
/*******MUTATORS AND ACCESSORS*******/
	public int getWidth(){return width;}
	public int getHeight(){return height;}
	public Handler getHandler() {return handler;}
	public void setHandler(Handler handler) {this.handler = handler;}
	public ItemManager getItemManager() {return itemManager;}
	public void setItemManager(ItemManager itemManager) {this.itemManager = itemManager;}
}
