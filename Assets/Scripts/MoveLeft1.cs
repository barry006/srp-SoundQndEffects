using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft1 : MonoBehaviour
{
    [SerializeField] float speed = 8;
    PlayerController3 playerControllerScript;
    private float leftBound = -10;

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
