using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public GameObject player;
    private Transform positionOfPlayer;
    private Vector2 currentposition;
    public float enemySpeed; 

    public float distance; //Distance/Range between player and enemy, before enemy travels towards player position. 

    void Start()
    {
        positionOfPlayer = player.GetComponent<Transform>();
        currentposition = GetComponent<Transform>().position; 
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, positionOfPlayer.position) < distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, positionOfPlayer.position, enemySpeed * Time.deltaTime); //will move enemy object toward player if either is in  a speific range(distance). 

        }
        else 
        {
            if (Vector2.Distance(transform.position, currentposition) <= 0)
            {

            }
            else 
            {
                transform.position = Vector2.MoveTowards(transform.position, currentposition, enemySpeed * Time.deltaTime);//ensures enemy returns back to origional position  
           
            }
        
        }
        
    }

}
