using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float heroSpeed;
    public float jumpForce;
    public Transform groundTester;
    public LayerMask layersToTest;
    Animator anim;
    Rigidbody2D rgdBody;
    bool dirToRight = true;
    public Transform startPoint;
    public GameObject pociskPrawa, pociskLewa;
    Vector2 pociskPoz;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;
    public Joystick joystick;

    private bool onTheGround;
    private float radius = 0.1f;

    void Start()
    {

        anim = GetComponent<Animator>();
        rgdBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("enemyContact"))
        {
            rgdBody.velocity = Vector2.zero;
            return;
        }
        onTheGround = Physics2D.OverlapCircle(groundTester.position, radius, layersToTest);

        float horizontalMove = joystick.Horizontal;
        if (joystick.Horizontal >= 0.2f)
        {

            horizontalMove = 1.0f;

        }
        else if (joystick.Horizontal <= -0.2f)
        {
            horizontalMove = -1.0f;
        }
        else
        {
            horizontalMove = 0f;
        }






        rgdBody.velocity = new Vector2(horizontalMove * heroSpeed, rgdBody.velocity.y);


        if (Input.GetKeyDown(KeyCode.Space) && onTheGround)
        {
            rgdBody.AddForce(new Vector2(0f, jumpForce));
            anim.SetTrigger("jump"); // wywołanie parametru jump

        }


        anim.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (Input.GetKeyDown(KeyCode.W) && Time.time > nextFire)
        {

            nextFire = Time.time + fireRate;
            fire();
        }

        if (horizontalMove < 0 && dirToRight) // strzałka w lewo
        {
            Flip();
        }

        if (horizontalMove > 0 && !dirToRight) //strzałka w prawo
        {
            Flip();
        }
    }
    void Flip()
    {

        dirToRight = !dirToRight;
        Vector3 heroScale = gameObject.transform.localScale
            ; heroScale.x *= -1; // odwrócenie skali na osi x
        gameObject.transform.localScale = heroScale;
    }

   public void fire()
    {
        pociskPoz = transform.position;

        if (dirToRight)
        {
            pociskPoz += new Vector2(+1f, -0.43f);
            Instantiate(pociskPrawa, pociskPoz, Quaternion.identity);
        }
        else
        {
            pociskPoz += new Vector2(-1f, -0.43f);
            Instantiate(pociskLewa, pociskPoz, Quaternion.identity);
        }
    }

    public void RestartHero()
    {
        gameObject.transform.position = startPoint.position;



    }


    public void jump()
    {
        if (gameObject.name == "Smok" && onTheGround)







            rgdBody.AddForce(new Vector2(0f, jumpForce));


        anim.SetTrigger("jump"); // wywołanie parametru jump

    }
}

