using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWorld : MonoBehaviour {

	public GameObject basicCandy;
	public GameObject basicBadCandy;
	public int candyLimit;

	double accumulatedTime;
	GameObject[] candyCopies;
	GameObject[] badCandies;
	GameObject[] specialCandies;
	int badCandyCount;
	int goodCandyCount;

	GameObject special;
	GameOverManager endGame;

	// Use this for initialization
	void Start () {

		endGame = GameObject.Find ("HUDCanvas").GetComponent<GameOverManager>();

		candyCopies = new GameObject[candyLimit];
		badCandies = new GameObject[candyLimit];

		specialCandies = GameObject.FindGameObjectsWithTag ("specialCandy");
		foreach(GameObject specialCandy in specialCandies) {
			specialCandy.SetActive(false);
		}

		goodCandyCount = candyLimit;
		badCandyCount = 0;

		for (int i = 0; i < candyLimit; i++) {
			GameObject candyCopy = Instantiate (basicCandy);
			candyCopies [i] = candyCopy;
			newPosition (candyCopy);
			candyCopy.SetActive (true);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
		accumulatedTime += Time.deltaTime;
		Debug.Log ("Cookies Left:" + goodCandyCount);
		// while there are good candies still on board
		if (goodCandyCount > 0) {
			// every 3 seconds, do following
			if (accumulatedTime > 3.0) {
				if (badCandyCount < (candyLimit - goodCandyCount)) {
					// bad candy every 3 sec
					GameObject badCandy = Instantiate (basicBadCandy);
					badCandies [badCandyCount] = badCandy;
					badCandyCount++;
					badCandy.SetActive (true);
				}

				// spawn ultra rare candies!!! 
				int choice = Random.Range (0, 3);
				Destroy (special);
//				int choice = 0;
				special = Instantiate (specialCandies [choice]);
				newPosition (special);
				special.SetActive (true);

					
				// reset positions every 3 sec
//				foreach (GameObject candyCopy in candyCopies) {
//					if (candyCopy != null) {
//						newPosition (candyCopy);
//					}
//				}
//				foreach (GameObject badCandyCopy in badCandies) {
//					if (badCandyCopy != null) {
//						newPosition (badCandyCopy);
//					}
//				}

				// reset timer
				accumulatedTime = 0.0;
			} 

		} else {
			endGame.gameOver ();
		}

			
	}

	void newPosition(GameObject g) {
		float x = Random.Range (-8.0f, 8.0f);
		float y = Random.Range (-4.0f, 2.5f);
		g.transform.position = new Vector3 (x, y, 0.0f);
	}

	public void deleteCandy() {
		goodCandyCount--;
	}

	public int candyCount() {
		return goodCandyCount;
	}

	void setupPhysics() {
		
	}
}
