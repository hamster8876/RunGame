using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip DeathClip;
    public float jumpForce = 700f;

    private int jumpCount = 0;
    private bool isGrounded = false;
    private bool isDead = false;

    private Rigidbody2D playerRigidbody;
    private Animator animator;
    private AudioSource playerAudio;


    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        return;
    }
    if (Input.GetMouseButtonDown(0) && jumpCount<2 ) {
        jumpCount++;
        playerRigidbody.velocity=Vector2.zero;
        playerRigidbody.AddForce(new Vector2(0, jumpForce));
        playerAudio.Play();
    }
else if(Input.GetMouseButtonUp(0)&&playerRigidbody.velocity.y)
}
