using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour

{
    private Rigidbody2D rb2D;
    private float thrust = 10.0f;

    private void Start()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
        transform.position = new Vector3(0.0f, -2.0f, 0.0f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(transform.up * thrust, ForceMode2D.Impulse);
        }
    }
}
