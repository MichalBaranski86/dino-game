using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siła : MonoBehaviour
{

    [SerializeField]
    private Vector2 force;
    [ContextMenu("ApplyForce")]// Start is called before the first frame update
    void Start()
    {
        ApplyForceToJoint();
    }

    // Update is called once per frame
    private void ApplyForceToJoint()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
            rb.AddForce(force);
        else
        {
            Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
            if (rb2D != null)
                rb2D.AddForce(force);

        }
    }
}
