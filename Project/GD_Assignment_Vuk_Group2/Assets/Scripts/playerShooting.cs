using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    //Shooting
    private float timeBWShots; //Time taken between projectile shots
    public float startTimeBWShots;

    public GameObject projectile;

    void Start()
    {
        timeBWShots = startTimeBWShots;

    }


    // Update is called once per frame
    void Update()
    {
        if (timeBWShots < 0)
        {
            if (Input.GetKeyDown("space"))
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBWShots = startTimeBWShots;
        }
        else
        {
            timeBWShots -= Time.deltaTime;

        }
    }
}
