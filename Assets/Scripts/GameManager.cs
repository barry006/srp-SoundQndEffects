using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
	//public TextMeshProUGUI gameOverText;

	//private int score;
	//public TextMeshProUGUI scoreText;
	bool rK;
	public GameObject reassignKey;  
	//public float timeScaleVariable2;
	private PAUSE pAUSE;
void Awake()
    {
		 
		//Screen.orientation = ScreenOrientation.LandscapeLeft; 
		//Screen.orientation = ScreenOrientation.AutoRotation; 
		reassignKey.gameObject.SetActive(true);
		//score = 0;
		//scoreText = "Score : " + score;
        
		//	UpdateScore(0);
    }

	void Start()
    {
		
		reassignKey.gameObject.SetActive(false);
		pAUSE = GameObject.Find("PauseButton").GetComponent<PAUSE>();
		
		//score = 0;
		//scoreText = "Score : " + score;        
		//	UpdateScore(0);
    }

    void Update()
    {

		if (Input.GetKeyDown(KeyCode.Tab))

			ButtonReassignKey();
		
	}
	//public void GameOver() {
	//gameOverText.gameObject.SetActive(true);
	//}



	public void ButtonReassignKey()
	{
		rK = !rK;

		if (rK)

		{
			//pAUSE.pause = true;
			
			
			//timeScaleVariable2 = Time.timeScale;
			//Time.timeScale=0;
			//pAUSE.GetComponent<PAUSE>().ButtonPause();
			//--------------
			//pAUSE.ButtonPause();
			reassignKey.gameObject.SetActive(true);
			
		}
		else
			
		{
			//pAUSE.pause = false;
			
			
		//	Time.timeScale=timeScaleVariable2;
			//-------------
			//pAUSE.ButtonPause();
			reassignKey.gameObject.SetActive(false);
		}
	}

		






}
