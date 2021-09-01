using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public GameObject WinEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Starting coroutine");
            StartCoroutine("WinDelay");
        }
    }


    IEnumerator WinDelay()
    {
        Debug.Log("You Win!!!... next level loading...");
        Instantiate(WinEffect, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Next level loaded... comment out sceneman thing");
    }
}
