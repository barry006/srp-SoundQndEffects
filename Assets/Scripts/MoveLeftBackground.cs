using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftBackground : MonoBehaviour
{
	[SerializeField] float speed = 8;
	[SerializeField] PlayerController3 playerControllerScript;
	
    void Update()
    {
		if (!playerControllerScript.gameOver) 
		{ 
			transform.Translate(speed * Time.deltaTime * Vector3.left); 
		} 
    }	
}
