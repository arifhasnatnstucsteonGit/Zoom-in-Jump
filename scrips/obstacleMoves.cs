using UnityEngine;
using System.Collections;

public class obstacleMoves : MonoBehaviour {

	public float obstaclemMoveSpeed=10.4f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-Vector2.right*obstaclemMoveSpeed*Time.deltaTime);
	
	}
}
