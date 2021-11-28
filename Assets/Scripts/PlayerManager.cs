using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    
    public TMP_Text scoreText;
    public float horizontalSpeed;
    public float jumpForce;
    public float swipeRange;
    public float tapRange;
    public static float forwardSpeed = 7;

    private bool canJump;

    Animator anim;
    Rigidbody rb;
    GameObject GameScreen;
    GameObject DeadScreen;
    GameObject FinishScreen;

    float horizontalInput;
    int score;


    void Start()
    {
        GameScreen = GameObject.Find("GameScreen");
        DeadScreen = GameObject.Find("DeadScreen");
        FinishScreen = GameObject.Find("FinishScreen");
        GameScreen.SetActive(true);
        DeadScreen.SetActive(false);
        FinishScreen.SetActive(false);
        anim = this.gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        PlayerControl();
    }

    

    #region Player Movement
    void PlayerControl()
    {
        #region Android Control

        //Vector3 forwardMove = transform.forward * forwardSpeed * Time.deltaTime;
        //rb.MovePosition(rb.position + forwardMove);

        //if (Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);

        //    if (touch.phase == TouchPhase.Moved)
        //    {
        //        horizontalInput = touch.deltaPosition.x;
        //        Vector3 horizontalMove = transform.right * horizontalInput * horizontalSpeed * Time.deltaTime;
        //        rb.MovePosition(rb.position + horizontalMove);
        //    }
        //    if (canJump == true)
        //    {
        //        for (int i = 0; i < Input.touchCount; i++)
        //        {
        //            if (i == 1)
        //            {
        //                anim.SetBool("Jump", true);
        //                rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        //                canJump = false;
        //            }
        //        }
        //    }

        //}

        #endregion


        #region PC Control

        horizontalInput = Input.GetAxis("Horizontal");
        Vector3 forwardMove = transform.forward * forwardSpeed * Time.deltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * horizontalSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);

        if (Input.GetButtonDown("Jump") && canJump == true)
        {
            anim.SetBool("Jump", true);
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            canJump = false;
        }

        #endregion
    }
    #endregion

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            anim.SetBool("Jump", false);
            canJump = true;
        }

        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
            GameScreen.SetActive(false);
            DeadScreen.SetActive(true);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            score += 1;
            scoreText.text = "" + score;
        }

        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
            GameScreen.SetActive(false);
            DeadScreen.SetActive(true);
        }

        if(other.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
            GameScreen.SetActive(false);
            FinishScreen.SetActive(true);
        }
    }

   
}
