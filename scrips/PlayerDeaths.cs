using UnityEngine;
using System.Collections;

public class PlayerDeaths : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) 
	{
		// If the Collider2D component is enabled on the object we collided with
		if(coll.gameObject.name=="obstacle(Clone)" || coll.gameObject.name=="obs1(Clone)" || coll.gameObject.name=="obs2(Clone)" || coll.gameObject.name=="obs3(Clone)"  || coll.gameObject.name=="obs4(Clone)" || coll.gameObject.name=="obs4(Clone)"|| coll.gameObject.name=="obs5(Clone)"){
			Destroy(gameObject);
			Application.LoadLevel(2);

			
			
		}
	}
}
