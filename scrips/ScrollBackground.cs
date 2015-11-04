using UnityEngine;
using System.Collections;

public class ScrollBackground : MonoBehaviour {

	public float moveSpeed=0.5f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 moves = - new Vector2 (Time.time*moveSpeed,0);

		GetComponent<Renderer>().material.mainTextureOffset = moves;
	
	}
}
