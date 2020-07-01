using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    bool changeSide = false;
    bool swipedRight = false;
    bool swipedLeft = false;
    bool swipedUp = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (!GameManager.instance.isPaused)
        {

            Vector3 vector = new Vector3(0, 0, 1);
            rb.AddForce(0, 0, GameManager.instance.ballSpeed * Time.deltaTime);

            if (transform.position.x > 0)
            {
                if (swipedLeft)
                {
                    transform.position = new Vector3(-5, transform.position.y, transform.position.z);
                    swipedLeft = false;
                }
            }
            else
            {
                if (swipedRight)
                {
                    transform.position = new Vector3(5, transform.position.y, transform.position.z);
                    swipedRight = false;
                }
            }

            if (swipedUp && NearlyEqual(transform.position.y, 1f))
            {
                rb.AddForce(0, GameManager.instance.jumpForce * Time.deltaTime, 0);
                swipedUp = false;
            }

            //if (Application.platform != RuntimePlatform.IPhonePlayer)
            //{

            //    if (changeSide)
            //    {

            //        transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);
            //        changeSide = false;
            //    }
            //    if (Input.GetKeyDown(KeyCode.Space) && NearlyEqual(transform.position.y, 1f))
            //    {
            //        rb.AddForce(0, GameManager.instance.jumpForce * Time.deltaTime, 0);
            //    }
            //}
            //else
            //{

            //    if (transform.position.x > 0)
            //    {
            //        if (swipedLeft)
            //        {
            //            transform.position = new Vector3(-5, transform.position.y, transform.position.z);
            //            swipedLeft = false;
            //        }
            //    }
            //    else
            //    {
            //        if (swipedRight)
            //        {
            //            transform.position = new Vector3(5, transform.position.y, transform.position.z);
            //            swipedRight = false;
            //        }
            //    }

            //    if (swipedUp && NearlyEqual(transform.position.y, 1f))
            //    {
            //        rb.AddForce(0, GameManager.instance.jumpForce * Time.deltaTime, 0);
            //        swipedUp = false;
            //    }
            //}
        }




        //if(Input.GetKey(KeyCode.Space)){
        //    rb.AddForce(Vector3.up * GameManager.instance.jumpForce * Time.deltaTime);
        //}

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            changeSide = true;
        }

    }

    public void SwipeUp()
    {
        swipedUp = true;
    }

    public void SwipeRight()
    {
        swipedRight = true;
    }

    public void SwipeLeft()
    {
        swipedLeft = true;
    }

    public static bool NearlyEqual(float f1, float f2)
    {
        // Equal if they are within 0.00001 of each other
        return Mathf.Abs(f1 - f2) < 0.1;
    }

}
