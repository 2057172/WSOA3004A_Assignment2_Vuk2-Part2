using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LumosOnAndOff : MonoBehaviour
{
    public Light2D LumosLight;
    public Light2D ConstantLight;
    public bool LightOn;
    public GameObject Obstacle;
    public GameObject[] Obstacles;
    public SpriteMask spriteMask;

    public void Start()
    {
        spriteMask = FindObjectOfType<SpriteMask>();
        Debug.Log("Started");
        Obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        LumosLight.GetComponent<Light2D>().intensity = 0;
        ConstantLight.GetComponent<Light2D>().intensity = 0.4f;
    }


    public void Update()
    {
        if (LightOn == false)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                LumosLight.GetComponent<Light2D>().intensity = 1;
                ConstantLight.GetComponent<Light2D>().intensity = 0;
                LightOn = true;
                spriteMask.transform.localScale = new Vector3(103f, 103f, 60f);
            }
        }
        else if (LightOn == true)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                LumosLight.GetComponent<Light2D>().intensity = 0;
                ConstantLight.GetComponent<Light2D>().intensity = 0.4f;
                LightOn = false;
                spriteMask.transform.localScale = new Vector3(60f, 60f, 60f);

            }
        }
    }

    

}
