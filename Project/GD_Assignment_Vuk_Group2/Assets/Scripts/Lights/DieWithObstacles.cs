using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieWithObstacles : MonoBehaviour
{
    public GameObject ObstacleEffect;
    SpriteRenderer Rend;

    //Color color;
    //public float AlphaLevel = 0;
    public LumosOnAndOff lumosscript;
    //Color colour;

    // Start is called before the first frame update
    void Start()
    {
        //Rend.color = new Color(1, 1, 1, 0);*/
        Rend = GetComponent<SpriteRenderer>();
        //colour = Rend.material.color;
        //colour.a = 0f;
        //Rend.material.color = colour;
        //Rend.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        if (lumosscript.LightOn == true)
        {
            //Debug.Log("Lights are on and traps are on");
            //Rend = GetComponent<SpriteRenderer>();
            //colour.a = 1f;
            //Rend.material.color = colour;
            //AlphaLevel += 255;
            //color.a = 1f;
            //Rend.color = new Color(1, 1, 1, 1);
            Rend.enabled = false;
        }
        else if (lumosscript.LightOn == false)
        {
            //Debug.Log("Lights are off and traps are off");
            //colour.a = 1f;
            //Rend.material.color = colour;
            //GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, 0);
            //color.a = 0f;
            //AlphaLevel -= 255;
            //Rend.color = new Color(1, 1, 1, 0);
            Rend.enabled = true;
        }
        
        //GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, AlphaLevel);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine("ObstacleEffectDelay");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    IEnumerator ObstacleEffectDelay()
    {
        Instantiate(ObstacleEffect, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
