using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    public float movementSpeed; //Will dictate the speed the player moves.
    public Rigidbody2D rBody;

    private Vector2 mDirection; // Directional movement 
                                

    // Update is called once per frame. Update function is better for input processes.
    void Update()
    {
        //Input Processing
        pMovementsInputs();
        
    }

    void FixedUpdate() // FixedUpdate is better for physics based calculations
    {
        //Physics Calculations
        move();
        
    }

    void pMovementsInputs() 
    {
        float movementX = Input.GetAxisRaw("Horizontal"); // Responsible for movement on x-Axis(horizontal).
       // float movementY = Input.GetAxisRaw("Vertical");  //  Responsible for movement on y-Axis(vertical).

        mDirection = new Vector2(movementX, 0f); // TODO RETURN

    }

    void move() 
    {
        rBody.velocity = new Vector2(mDirection.x * movementSpeed, mDirection.y * movementSpeed);
    
    }
}
