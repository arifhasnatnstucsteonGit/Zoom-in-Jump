using UnityEngine;
using System.Collections;

public class buttonCommands : MonoBehaviour {

	public void StartGame(){

		Application.LoadLevel (1);
	}
	public void ExitGame(){

		Application.Quit();

		if (Application.platform == RuntimePlatform.Android)
		{
			Application.Quit();
		}
	}
	
}
