using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwSpriteHerbe : MonoBehaviour
{
    [SerializeField] GameObject[] spritePrefab;
    [SerializeField] float startDelay = 2;
    [SerializeField] private float spawnInterval = 3.5f;    
    [SerializeField] float vectorX = 0;
    [SerializeField] float vectorY = 0;
    [SerializeField] float vectorZ = 0;
    private PlayerController3 playerControllerScript;
    void Start()
    {
        StartCoroutine(annuleHerbeCoroutine());
        {
            InvokeRepeating("SpawnSpriteInvoke", startDelay, spawnInterval);
            playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController3>();
        }
    }

    IEnumerator annuleHerbeCoroutine()
    {
        yield return new WaitForSeconds(10);
        //CancelInvoke();	
    }
    void SpawnSpriteInvoke()
    {
        if (!playerControllerScript.gameOver)
        {
            int spriteIndex = Random.Range(0, spritePrefab.Length);
            Vector3 spawnpos = new(vectorX, vectorY, vectorZ);
            Instantiate(spritePrefab[spriteIndex], spawnpos, spritePrefab[spriteIndex].transform.rotation);
        }
    }
}
