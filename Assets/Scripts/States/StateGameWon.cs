using UnityEngine;

public class StateGameWon : GameState {
	
	private float m_countDown = 5f;

	public StateGameWon(GameManager gm):base(gm) { }

	public override void Enter() {
		
	}

	public override void Execute() {
	}

	public override void Exit() {}

		public void PlayGame() {
		m_gm.NewGameState(m_gm.m_stateGamePlay);
		
	}
	void Update()
	{
		
	}
	public void QuitGame() {
		Application.Quit();
	}
}


