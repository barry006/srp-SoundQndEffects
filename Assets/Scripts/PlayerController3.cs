using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using UnityEditor.Animations;
public class PlayerController3 : MonoBehaviour
{
    public bool gameOver = false;
    [SerializeField] float forceJump;
    [SerializeField] float gravityModifier;
    [SerializeField] bool isOnGround = true;
    [SerializeField] bool isCrouch = false;
    [SerializeField] Animator playerAnim;
    [SerializeField] ParticleSystem explosionParticle;
    [SerializeField] ParticleSystem dirtParticle;
    [SerializeField] AudioSource playerAudio;
    [SerializeField] AudioClip jumpSound;
    [SerializeField] float jumpVolume;
    [SerializeField] AudioClip crashSound;
    [SerializeField] float crashVolume;
    [SerializeField] AudioClip crouchSound;
    [SerializeField] float crouchVolume;
    [SerializeField] GameObject canvas;
    private Rigidbody playerRb;
    bool mirrorAnim;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }
    void Start()
    {
        Physics.gravity *= gravityModifier;
    }
    //--------------------------------------	 
    void Update()
    {
        if (KeyBindingManager.GetKeyDown(KeyAction.jump))
        {
            JumpingVoid();
        }

        if (KeyBindingManager.GetKeyDown(KeyAction.slide))
        {
            CrouchVoid();
        }


        if (Input.GetKeyDown(KeyCode.T) && !gameOver)
        {
            Time.timeScale = Time.timeScale + 1f;
        }
    }

    //--------------------------------------
    public void JumpingVoid()
    {
        if (isOnGround && !gameOver && !isCrouch)
        {
            playerRb.AddForce(Vector3.up * forceJump, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, jumpVolume);
        }
    }
    //--------------------------------------
    public void CrouchVoid()
    {
        if (isOnGround && !gameOver && !isCrouch)
        {
            //anim Mirror
            mirrorAnim = (Random.value > 0.5f);
            if (mirrorAnim)
            {
                playerAnim.SetBool("Mirror", true);
            }
            else
            {
                playerAnim.SetBool("Mirror", false);
            }
            playerAnim.SetTrigger("Crouch_trig");
            isCrouch = true;
            StartCoroutine(ExampleCoroutine());
            playerAudio.PlayOneShot(crouchSound, crouchVolume);
        }
    }
    //--------------------------------------
    IEnumerator ExampleCoroutine()
    {
        if (!gameOver)
        {
            yield return new WaitForSeconds(0.7f);
            isCrouch = false;
        }
    }
    //--------------------------------------
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") && !gameOver)
        {
            isOnGround = true;
            dirtParticle.Play();
        }
    }
    //--------------------------------------
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("obstacle") && !gameOver)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        gameOver = true;
        canvas.gameObject.SetActive(true);
        playerAnim.SetBool("Death_b", true);
        playerAnim.SetInteger("DeathType_int", 1);
        explosionParticle.Play();
        dirtParticle.Stop();
        playerAudio.PlayOneShot(crashSound, crashVolume);
    }
}



