using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float playerSpeed;
    public float jumpForce;
    public float playerForwardSpeed;
    private float horizontalInput;    
    private float xBound = 3f;
    private Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        

    }

    void Update()
    {
        PlayerMovement();
        
    }

    private void PlayerMovement()
    {
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
        playerRb.AddForce(Vector3.forward * playerForwardSpeed, ForceMode.Force);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontalInput);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            playerRb.AddForce(Vector3.forward * 3, ForceMode.Impulse);
        }

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject == GameObject.Find("Animal1") || collision.gameObject == GameObject.Find("Animal2"))
    //    {
    //        transform.position = collision.gameObject.transform.position;
    //    }
    //}



}
