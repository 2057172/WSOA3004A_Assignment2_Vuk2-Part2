using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTwo : MonoBehaviour
{

    public GameObject target;
    public Transform playerX;
    public Transform CamTransform;

    public float targetX;
    public float targetY;

    void Update()
    {
        targetX = target.GetComponent<Transform>().position.x;
        targetY = target.GetComponent<Transform>().position.y;

        CamTransform.position = new Vector3(playerX.position.x, targetY, transform.position.z);
    }
}
