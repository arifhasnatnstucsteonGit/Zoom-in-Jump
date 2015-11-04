using UnityEngine;
using System.Collections;

public class obstacleSpawner : MonoBehaviour {

	public GameObject[] positionSpawner;
	int obsNo;

    float timer;
	public float delaytimer=1f;

	// Use this for initialization
	void Start () {
		timer = delaytimer;
	
	}
	
	// Update is called once per frame
	void Update () {
		//Instantiate (positionSpawner,transform.position,transform.rotation);
		timer -= Time.deltaTime;

		if(timer<=0){
			Vector3 carPos=new Vector3(Random.Range(7.0f,20.0f),transform.position.y,transform.position.z);
			obsNo=Random.Range(0,6);
			Instantiate (positionSpawner[obsNo],carPos,transform.rotation);
			timer = delaytimer;

		}



	
	}
}
