using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class restartLevel : MonoBehaviour
{
    private PAUSE pauseVariable;
    void Awake()
    {
        pauseVariable = GameObject.Find("PauseButton").GetComponent<PAUSE>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && pauseVariable.pause == false)
        {
            RestartGame();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Physics.gravity = new Vector3(0, -9.81f, 0);
        Time.timeScale = 1;
    }
}