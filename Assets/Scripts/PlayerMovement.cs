using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//[System.Serializable]
//public class Boundary
//{
//  public float xmin, xmax,zmin,zmax;
//}
public class PlayerMovement : MonoBehaviour
{
    //public Boundary boundary;
    private Rigidbody rb;
    public float speed;
    public float forwardSpeed;
    public float playercontrolling;
    public bool isPlayingCheck = true;
    public GameObject maincamera;
    public GameObject gameOver;
    public GameObject gameWin;
    public GameObject Level;
    private bool isPlayButtonPressed;
    public Image progressBarImg;
    public float waitTimeProgressBar = 20f;
    Vector3 posCompare;
    //Hassan's code
    float forwardspeed = 15f;
    float startspeed = 5f;
    float turnspeed = 10f;
    //public Animator Playeranim;
    // Start is called before the first frame update
    // public GameObject PlayButtongameObject;
    private void Awake()
    {
        gameOver.SetActive(false);
        isPlayButtonPressed = false;
        //   PlayButtongameObject.SetActive(true);
        //  Playeranim = GetComponent<Animator>();
        posCompare = this.transform.position;
        Debug.Log("PosCompare Value at awake is : " + posCompare);
    }
    private void Update()
    {
        //rb.AddForce()
        //Debug.Log("Values for player position at z "+this.transform.position.z + "Values for Pos compare " + posCompare.z);
        //if (this.transform.position.z >= posCompare.z)
        ////transform.Translate(0, 0,forwardSpeed* Time.deltaTime);
        //{
        //    Debug.Log("if part executes");
        //    transform.position += Vector3.forward * forwardSpeed * Time.deltaTime;
        //}
        //else
        //{
        //    transform.position += Vector3.forward *-1* forwardSpeed * Time.deltaTime;
        //    Debug.Log("else part executes");
        //}
        //posCompare = this.transform.position;
        progressBarImg.fillAmount += 1f / waitTimeProgressBar * Time.deltaTime;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    //private void FixedUpdate()
    //{
    //    // if (isPlayingCheck)
    //    // rb.AddForce(Vector3.forward*FD/10);
    //    //// rb.AddForce(Vector3.forward * Time.timeScale);

    //    float horizontalMovement = Input.GetAxis("Horizontal");
    //    float verticalMovement = Input.GetAxis("Vertical");
    //        //        verticalMovement = Mathf.Clamp01(verticalMovement - playercontrolling);//Restrict the player from moving beyond the camera..

    //        //Debug.Log(maincamera.transform.position.z);

    //        Vector3 movement = new Vector3(horizontalMovement, 0.0f, verticalMovement);
    //        rb.AddForce(movement * speed);
    //        //rb.position = new Vector3
    //        //    (
    //        //    Mathf.Clamp(rb.position.x, boundary.xmin, boundary.xmax),
    //        //    0.0f,
    //        //    Mathf.Clamp(rb.position.z, boundary.zmin, boundary.zmax)
    //        //    );

    //}
    //Hassan's Code
    private void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // if (finish == 0 && enemycollision == false)
        {
            Vector3 movement_Hor = new Vector3(moveHorizontal, 0, 0);
            Vector3 movement_Ver = new Vector3(0, 0, moveVertical);

            //Always movement
            rb.AddForce(new Vector3(0, 0, startspeed));

            //On Left Right Keys
            rb.AddForce(movement_Hor * turnspeed);

            //On Forward and Backward Keys
            rb.AddForce(movement_Ver * forwardspeed);

            //---------------Checking Boundaries
            //if (transform.position.x > 5.8f)
            //{
            // transform.position = new vector3(5.8f, transform.position.y, transform.position.z);
            //}
            //if (transform.position.x < -5.8f)
            //{
            // transform.position = new vector3(-5.8f, transform.position.y, transform.position.z);
            //}
        }

        if (transform.position.x > 5.8f)
        {
            transform.position = new Vector3(5.8f, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -5.8f)
        {
            transform.position = new Vector3(-5.8f, transform.position.y, transform.position.z);
        }

        //if (Input.GetKey(KeyCode.Mouse1))
        //{
        // mouseClick = 1;
        // transform.Translate(0, 0, ballspeed);
        //}
        //if (mouseClick == 1)
        //{
        // transform.Translate(0, 0, ballspeed);
        // if (Input.GetKey(KeyCode.UpArrow))
        // {
        // transform.Translate(0, 0, ballspeed + increasespeed);
        // }
        // if (Input.GetKey(KeyCode.DownArrow))
        // {

        // transform.Translate(0, 0, ballspeed - increasespeed);
        // }
        // if (Input.GetKey(KeyCode.RightArrow))
        // {

        // transform.Translate(ballspeed, 0, 0);
        // }
        // if (Input.GetKey(KeyCode.LeftArrow))
        // {

        // transform.Translate(-ballspeed, 0, 0);
        // }
        //}


    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.GetComponent<Renderer>().material.color != this.gameObject.GetComponent<Renderer>().material.color)
        //{
        //    Destroy(this.gameObject);
        //}
        if (collision.gameObject.tag == "Prism" || collision.gameObject.tag == "Floor")
        {
        }

        else if (collision.gameObject.tag == "Win")
        {
            Level.SetActive(false);
            gameWin.SetActive(true);
        }
        else
        {
            //Destroy(this.gameObject);
            gameOver.SetActive(true);
            Level.SetActive(false);
        }
    }
    // Update is called once per frame
    //    void Update()
    //    {
    //        float horizontalMovement = Input.GetAxis("Horizontal");
    //        float verticalMovement = Input.GetAxis("Vertical");
    ////        verticalMovement = Mathf.Clamp01(verticalMovement - playercontrolling);//Restrict the player from moving beyond the camera..
    //        verticalMovement = Mathf.Clamp01(maincamera.transform.position.z);
    //        Debug.Log((maincamera.transform.position.z);
    //        Vector3 movement = new Vector3(horizontalMovement, 0.0f, verticalMovement);
    //        rb.AddForce(movement * speed);
    //        //rb.position = new Vector3
    //        //    (
    //        //    Mathf.Clamp(rb.position.x, boundary.xmin, boundary.xmax),
    //        //    0.0f,
    //        //    Mathf.Clamp(rb.position.z, boundary.zmin, boundary.zmax)
    //        //    );
    ////    }
    //public void PlayButtonClick()
    //{
    //    isPlayButtonPressed = true;
    //   // PlayButton.interactable = false;
    //}
}