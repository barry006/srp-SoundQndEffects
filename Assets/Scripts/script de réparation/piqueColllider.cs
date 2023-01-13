using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piqueColllider : MonoBehaviour
{
	private PlayerController3 playerControllerScript;
   
    void Start()
    {
       playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController3>(); 
    }
    void Update()
    {
        
    }
	
	
	
	
	
	
	private void OnTriggerEnter(Collider collision) 
	{
	
		if(collision.gameObject.CompareTag("Player")&& !playerControllerScript.gameOver) 
		{ 
			Debug.Log("collisionnnntrig");
				playerControllerScript.GameOver();
				
		 
			
		}	
			
	}
	
	
	
	
	
}
