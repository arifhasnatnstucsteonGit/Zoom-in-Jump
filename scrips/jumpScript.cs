using UnityEngine;
using System.Collections;

public class jumpScript : MonoBehaviour {

	public float jumpSpeed=30.0f;

	public AudioManager am;




	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


			if(Input.touchCount>0){
			if(transform.position.y<-4.0){
				transform.Translate(Vector2.up*jumpSpeed);

				am.audio.Play();
			}
				
			}
			if(Input.GetKeyDown(KeyCode.A)){
				
				if(transform.position.y<-4.0){
					transform.Translate(Vector2.up*jumpSpeed);
				    am.audio.Play();
				}
				
			}




	


	
	}
}
