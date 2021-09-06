using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class patrolScript : MonoBehaviour
{
    public float speed;
    public Transform[] mSpots;
    private int randomPos; // picks random positiion from  the mSpot arrey 

    //Enemy Reaches Point 
    private float waitTime;
    public float startWaitTime;

    void Start()
    {
        waitTime = startWaitTime;
        randomPos = Random.Range(0,mSpots.Length);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, mSpots[randomPos].position, speed * Time.deltaTime); // moves object from current position to random mSpot. 

        if (Vector2.Distance(transform.position,mSpots[randomPos].position) < 0.2f ) 
        {
            if (waitTime <= 0)
            {
                randomPos = Random.Range(0, mSpots.Length);
                waitTime = startWaitTime;
            }
            else 
            {
                waitTime -= Time.deltaTime;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}
