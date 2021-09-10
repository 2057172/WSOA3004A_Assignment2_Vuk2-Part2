using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapFollow : MonoBehaviour
{
    public Transform player;
    public float moveSpeed;
    public LumosOnAndOff lumos;

    private Rigidbody2D rBody;

    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
       
        rBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.transform.CompareTag("Player"))
        if(collision.gameObject.tag == "MainLight" && lumos.LightOn == false)
        {
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rBody.rotation = angle;
            direction.Normalize();
            movement = direction;

        } else if(collision.gameObject.tag == "MainLight" && lumos.LightOn == true)
        {
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rBody.rotation = angle;
            direction.Normalize();
            movement = direction * 2;
        }
    }

    void FixedUpdate()
    {
        enemyMovement(movement);
    }


    void enemyMovement(Vector2 direction) 
    {
        rBody.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime)); // moves current position of enemy to desired/specified player position. 
    
    }

}
