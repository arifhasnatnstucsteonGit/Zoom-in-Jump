using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {

	public Text scoreText;
	public float score;
	
	// Use this for initialization
	void Start () {
		score = 0;
		InvokeRepeating ("ScoreUpdate",1.0f,0.5f);
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score : " + score*10;
		
	}

	void ScoreUpdate(){
	

		score += 1;
	}




	public void Pause(){
		if(Time.timeScale==1){
			Time.timeScale=0;


		}else if(Time.timeScale==0){
			Time.timeScale=1;

		}

	}

}
