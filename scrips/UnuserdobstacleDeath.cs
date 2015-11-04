using UnityEngine;
using System.Collections;

public class UnuserdobstacleDeath : MonoBehaviour {

	public AudioClip death;

	void OnCollisionEnter2D(Collision2D coll) 
	{
		// If the Collider2D component is enabled on the object we collided with
		if(coll.gameObject.name=="obstacle(Clone)" || coll.gameObject.name=="obs1(Clone)" || coll.gameObject.name=="obs2(Clone)" || coll.gameObject.name=="obs3(Clone)" || coll.gameObject.name=="obs4(Clone)" || coll.gameObject.name=="obs5(Clone)"){
			Destroy(coll.gameObject);



			
			
			
		}
	}
}
