using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwSprite2 : MonoBehaviour
{
    [SerializeField] GameObject[] spritePrefab;
    [SerializeField] float startDelay = 2;
    [SerializeField] float spawnInterval = 3.5f;
    [SerializeField] PlayerController3 playerControllerScript;
    void Start()
    {
        InvokeRepeating("SpawnSpriteInvoke", startDelay, spawnInterval);
    }
    void SpawnSpriteInvoke()
    {
        if (!playerControllerScript.gameOver)
        {
            var spriteIndex = Random.Range(0, spritePrefab.Length);
            Vector3 spawnpos = new(39, 3.8f, 5);
            Instantiate(spritePrefab[spriteIndex], spawnpos, spritePrefab[spriteIndex].transform.rotation);
        }
    }
}
