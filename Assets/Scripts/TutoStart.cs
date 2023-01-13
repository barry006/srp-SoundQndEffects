using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoStart : MonoBehaviour
{
    static bool tuto = true;
    [SerializeField] GameObject spawnManager;
    [SerializeField] GameObject timer;
    [SerializeField] GameObject uiStartTuto;    

    void Awake()
    {
        if (tuto)
        {
            spawnManager.SetActive(false);
            timer.SetActive(false);
            uiStartTuto.SetActive(true);
        }
        else
        {
            spawnManager.SetActive(true);
            timer.SetActive(true);
            uiStartTuto.SetActive(false);
        }
    }
    public void ButtonStopTuto()
    {
        tuto = false;
        uiStartTuto.SetActive(false);
        timer.SetActive(true);
        spawnManager.SetActive(true);
    }
}
