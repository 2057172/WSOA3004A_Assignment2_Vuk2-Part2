using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gMasterScript : MonoBehaviour
{
    private static gMasterScript spawnInstance;
    public Vector2 prevCheckpointPos;

    void Awake()
    {
        if (spawnInstance == null) 
        {
            spawnInstance = this;
            DontDestroyOnLoad(spawnInstance); 
        
        }
        
    }
}
