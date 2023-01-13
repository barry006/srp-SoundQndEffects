using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerP3 : MonoBehaviour
{

    [SerializeField] GameObject[] obstaclePrefabList;
    Vector3 spawnPos = new Vector3(15.9f, 10, 0);
    private float minRandomInterval = 1f;
    private float maxRandomInterval = 2f;
    [SerializeField] PlayerController3 playerControllerScript;

    void Start()
    {
        SpawnObstacle();
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            int obstacleIndex = Random.Range(0, obstaclePrefabList.Length); 
            
            //Equilibrage a vérifier si toujours d'actualité, ou a optimiser.            
            if (obstacleIndex == 4)
            {
                Instantiate(obstaclePrefabList[obstacleIndex], new Vector3(17.12f, -5.2f, 0.43f), obstaclePrefabList[obstacleIndex].transform.rotation);
            }
            else
            {
                Instantiate(obstaclePrefabList[obstacleIndex], spawnPos, obstaclePrefabList[obstacleIndex].transform.rotation);
            }
            if (obstacleIndex == 1)
            {
                Invoke("SpawnObstacle", Random.Range(1.5f, 2));
            }
            else
            {
                Invoke("SpawnObstacle", Random.Range(minRandomInterval, maxRandomInterval));
            }
            //----------------------------------------------------------
        }
    }

}


