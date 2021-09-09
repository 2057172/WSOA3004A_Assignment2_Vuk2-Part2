using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLogic : MonoBehaviour
{
    public bool isMoving;
    public Rigidbody2D rb;
    public float movementSpeed = 80;

    void Start()
    {
        isMoving = true;
    }

    public void FixedUpdate()
    {
        if (isMoving == true)
        {
            rb.velocity = new Vector2(0f, -movementSpeed) * Time.deltaTime;

        }
        else if (isMoving == false)
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CameraStopper")
        {
            isMoving = false;
        }
    }
}
