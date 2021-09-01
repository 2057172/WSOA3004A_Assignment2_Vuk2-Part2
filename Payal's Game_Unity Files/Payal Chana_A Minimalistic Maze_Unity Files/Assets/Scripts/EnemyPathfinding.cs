using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyPathfinding : MonoBehaviour
{
    public GameObject LoseEffect;
    public Transform target;
    NavMeshAgent agent;

    public float AgroRange;
    private Rigidbody2D rb;

    public LumosOnAndOff lumosonandoffscript;

    public GameObject GlobalLight;

    // Start is called before the first frame update
    void Start()
    {

        GlobalLight.SetActive(false);
        rb = GetComponent<Rigidbody2D>();

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        float DistanceFromPlayer = Vector2.Distance(transform.position, target.position);

        if (DistanceFromPlayer < AgroRange && lumosonandoffscript.LightOn == true)
        {
            agent.SetDestination(target.position);
        }
        else
        {
            //Stop chasing the player
            StopChasingPlayer();
        }
    }

    public void StopChasingPlayer()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine("Playerdeath");
        }
    }
   
    IEnumerator Playerdeath()
    {
        rb.velocity = new Vector2(0, 0);
        Instantiate(LoseEffect, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
