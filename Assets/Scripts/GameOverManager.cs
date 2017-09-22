using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour {

	Animator animator;
	public bool end;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		end = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void gameOver() {
		end = true;
		animator.SetTrigger ("GameOver");
	}
}
