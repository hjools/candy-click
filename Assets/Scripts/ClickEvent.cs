using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour {
	public enum CandyType {good, bad};

	public int scoreValue;
	public GameObject gameRunner;
	public CandyType candy;

	ScoreDisplayer s;
	CreateWorld c;
	GameOverManager g;

	// Use this for initialization
	void Start () {
		s = gameRunner.GetComponent<ScoreDisplayer> ();
		c = gameRunner.GetComponent<CreateWorld> ();
		g = GameObject.Find ("HUDCanvas").GetComponent<GameOverManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		if (g.end) {
			return;
		} else {
			s.updateScore (scoreValue);
			if (candy == CandyType.good) {
				c.deleteCandy ();
			}
			Destroy (this.gameObject);
		}
	}
}
