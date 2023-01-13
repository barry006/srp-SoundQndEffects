using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float elapsedTime;
    [SerializeField] float TimerInterval = 5f;
    [SerializeField] PAUSE pAUSE;
    [SerializeField] AudioClip bipSound;
    [SerializeField] SliderScript sliderScript;
    [SerializeField] float maxVariable = 2;

    float time;
    float tick;
    float elapsedTimePause;
    bool gameOverBool = false;
    private PlayerController3 playerControllerScript;
    private AudioSource playerAudio;
    int seconde;

    void Awake()
    {
        time = (float)Time.time;
        tick = TimerInterval;
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController3>();
        playerAudio = GetComponent<AudioSource>();
    }
    //---------------------------		
    void Start()
    {
        sliderScript.SetMaxSliderValue(maxVariable);
        StartCoroutine(SpeedTimeCoroutine());
    }


    IEnumerator SpeedTimeCoroutine()
    {
        if (!gameOverBool)
        {
            sliderScript.SetSliderValue(Time.timeScale);
            seconde += 10;
            yield return new WaitForSeconds(seconde);
            Time.timeScale += 0.1f;
            playerAudio.PlayOneShot(bipSound, 0.5f);
            if (Time.timeScale < maxVariable)
            {
                StartCoroutine(SpeedTimeCoroutine());
            }
        }
    }

    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            if (!pAUSE.pause)
            {
                elapsedTimePause = elapsedTime;
                elapsedTime += Time.deltaTime / (Time.timeScale);
            }

            else
            {
                elapsedTime = elapsedTimePause;
            }

            GetComponent<Text>().text = string.Format("{0:00}:{1:00}:{2:00}", Mathf.Floor(elapsedTime / 60), elapsedTime % 60, (elapsedTime * 100) % 100);
            time = (float)Time.time;

            if (time == tick)
            {
                tick = time + TimerInterval;
            }
        }

        else
        {
            gameOverBool = true;
            playerAudio.Stop();
        }

    }
}