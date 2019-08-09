import java.awt.Graphics;

public class WinningState extends State {

	public WinningState(Handler h) {
		super(h);
		// TODO Auto-generated constructor stub
	}

	@Override
	public void tick() {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void render(Graphics g) {
		g.drawImage(Assets.getWinningBackGround(), 0, 0, null);//the final screen the user sees
		
	}

}
