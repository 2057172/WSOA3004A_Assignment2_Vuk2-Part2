using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazardsScript : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
            collision.transform.position = spawnPoint.position;

        if (collision.gameObject.tag == "respawnProjectile") 
        {
            Destroy(collision.gameObject);
        
        }
        
    }
}
