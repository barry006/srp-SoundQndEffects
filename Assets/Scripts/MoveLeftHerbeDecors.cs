using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftHerbeDecors : MonoBehaviour
{
    [SerializeField] float speed = 8;
    private PlayerController3 playerControllerScript;
    private float leftBound = -15;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController3>();
    }

    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound)
        {
            speed = 0;
        }
    }

}
