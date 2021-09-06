using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotation : MonoBehaviour
{
    private float rotate2;
    public float rotationSpeed;
    public bool clockwise;



    // Update is called once per frame
    void Update()
    {
        if (clockwise == false)
        {
            rotate2 += Time.deltaTime * rotationSpeed;

        }
        else 
        {
            rotate2 += -Time.deltaTime * rotationSpeed;
        
        }
        transform.rotation = Quaternion.Euler(0, 0, rotate2);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("Boua aint no way boua");
            Application.Quit();
        }
    }
}
