using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] float speed = 30;
    private PlayerController3 playerControllerScript;
    private float leftBound = -12;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController3>();
    }

    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }

        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

    }



}
