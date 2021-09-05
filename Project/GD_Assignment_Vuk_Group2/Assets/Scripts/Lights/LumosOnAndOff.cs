using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LumosOnAndOff : MonoBehaviour
{
    //public Light Light;
    public bool LightOn;
    public GameObject Obstacle;
    public GameObject[] Obstacles;

    public void Start()
    {
        Debug.Log("Started");
        Obstacles = GameObject.FindGameObjectsWithTag("Obstacle");

    }


    public void Update()
    {
        if (LightOn == false)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                this.GetComponent<Light2D>().intensity = 1;
                LightOn = true;
                foreach (GameObject _gameobject in Obstacles)
                {
                    //Rend.color = new Color(0.5f, 0.5f, 0.5f, 1);
                    //Rend.enabled = true;
                }
                if (gameObject.CompareTag ("Obstacle"))
                {
                    //Rend.enabled = true;
                    //Rend.color = new Color(0.5f, 0.5f, 0.5f, 1);
                }
                /*if (gameObject.CompareTag ("Trap"))
                {
                    Trap.SetActive(true);
                }
                foreach (GameObject _gameobject in Traps)
                {
                    _gameobject.SetActive(true);
                }*/

            }
        }
        else if (LightOn == true)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                this.GetComponent<Light2D>().intensity = 0;
                LightOn = false;

                foreach (GameObject _gameobject in Obstacles)
                {
                    //Rend.enabled = false;
                   // Rend.color = new Color(0.5f, 0.5f, 0.5f, 0);
                }
                if (gameObject.CompareTag("Obstacle"))
                {
                    //Rend.enabled = false;
                    //Rend.color = new Color(0.5f, 0.5f, 0.5f, 0);
                }
                /*if (gameObject.CompareTag("Trap"))
                {
                    Trap.SetActive(false);
                }
                foreach (GameObject _gameobject in Traps)
                {
                    _gameobject.SetActive(false);
                }*/
            }
        }

        


        /*if (Input.GetKeyDown(KeyCode.L))
        {
            LightOn = true;
            if (LightOn == false)
            {
                this.GetComponent<Light2D>().intensity = 0;
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                LightOn = false;
                if (LightOn == true)
                {
                    this.GetComponent<Light2D>().intensity = 1;
                }
            }
        }*/
    }

    

}
