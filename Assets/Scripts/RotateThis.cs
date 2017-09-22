using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateThis : MonoBehaviour {
	
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (0.0f, 0.0f, speed);
	}

}
