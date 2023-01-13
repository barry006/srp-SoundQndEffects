using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
	//public GameObject myGameObject;
	//float ScaleMe;
    private void Update()
	{
	//RaycastHit[] hits;
	//hits = Physics.RaycastAll(transform.position, transform.Input.mouseX, 10);
	
// Debug.DrawRay(transform.position, transform.Input.mouseX*10, Color.red);
	
	Debug.DrawRay(gameObject.transform.position, Input.mousePosition, Color.red);
	//	Debug.Log("il y a " + hits.Length + " objet touché.");		
	//----------------------
	if (Input.GetMouseButtonDown(0))
	{
	//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		//Debug.DrawRay(gameObject.transform.position, Input.mousePosition, Color.red);
		//Debug.DrawRay((new Vector3(0, 0, 0)), Input.mousePosition, Color.yellow);
	}
	//--------------------------	

//if (Physics.Raycast(ray, out RaycastHit hit, 100)) {
	//Debug.Log(hit.transform.name);
	//Debug.Log("hit");
//}
	

	 
	 
   
 
	
	
	}
}
