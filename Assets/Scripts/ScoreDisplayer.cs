using UnityEngine;
using System.Collections;

public class ScoreDisplayer : MonoBehaviour {

	public static int score;
//	GUIStyle guiStyle;
//	bool guiStyleSetup=false;

	UnityEngine.UI.Text text;

//	void OnGUI() 
//	{
//		if (guiStyleSetup == false) 
//		{
//			guiStyle = new GUIStyle (GUI.skin.label); 
//			guiStyle.fontSize = 50;
//			guiStyleSetup = true;
//		}
//		GUI.Label (new Rect (10, 10, 400, 400), "Score: " + score,guiStyle);
//	}

	public void updateScore(int change)
	{
		score += change;
		text.text = "Score: " + score;
	}

	// Use this for initialization
	void Start ()
	{	
		score = 0;
		GameObject t = GameObject.Find ("ScoreText");
		text = t.GetComponent<UnityEngine.UI.Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public int getScore() {
		return score;
	}
}
