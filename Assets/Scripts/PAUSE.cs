using UnityEngine;
using UnityEngine.UI;

public class PAUSE : MonoBehaviour
{
    public bool pause = false;

    Sprite imageOn;
    [SerializeField] Sprite imageOff;
    [SerializeField] Button button;
    [SerializeField] GameObject blurCanvas;
    [SerializeField] float timeScaleVariable;
    [SerializeField] PlayerController3 playerControllerScript;
    private void Awake()
    {
        imageOn = button.image.sprite;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && !playerControllerScript.gameOver)
            ButtonPause();
    }
    public void ButtonPause()
    {
        pause = !pause;

        if (pause && !playerControllerScript.gameOver)
        {
            timeScaleVariable = Time.timeScale;
            Time.timeScale = 0;
            AudioListener.volume = 0;
            button.image.sprite = imageOff;
            blurCanvas.SetActive(true);
        }
        else
        {
            if (!playerControllerScript.gameOver)
            {
                Time.timeScale = timeScaleVariable;
                AudioListener.volume = 1;
                button.image.sprite = imageOn;
                blurCanvas.gameObject.SetActive(false);
            }
        }
    }
}
