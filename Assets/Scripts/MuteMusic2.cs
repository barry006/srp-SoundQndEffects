using UnityEngine;
using UnityEngine.UI;

public class MuteMusic2 : MonoBehaviour
{
    public static bool isMute = false;

    Sprite soundOnImage;
    [SerializeField] Sprite soundOffImage;
    [SerializeField] Button button;
    [SerializeField] AudioSource audioSource;
    void Start()
    {
        soundOnImage = button.image.sprite;

        if (isMute)
        {
            button.image.sprite = soundOffImage;
            audioSource.mute = true;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
            ButtonClicked();
    }
    public void ButtonClicked()
    {
        if (!isMute)
        {
            button.image.sprite = soundOffImage;
            isMute = true;
            audioSource.mute = true;
        }
        else
        {
            button.image.sprite = soundOnImage;
            isMute = false;
            audioSource.mute = false;
        }
    }
}
