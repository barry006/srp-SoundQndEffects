using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class votreScoreEst : MonoBehaviour
{
    [SerializeField] private PlayerController3 playerControllerScript;
    [SerializeField] private TimerScript timerScript;
    [SerializeField] private Text texte;
    void Update()
    {
        if (playerControllerScript.gameOver == true)
        {
            texte.text = string.Format("Votre Temps est de :" + timerScript.elapsedTime % 60 + "secondes");
        }
    }
}
