using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{   
    public CameraFollow cam;
    public Transform target;
    public Vector3 offset;

    void Start() {
        
        //cam = GameObject.FindGameObjectsWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {

        if (target != null)
        {
            transform.LookAt(target.transform);
        }
        transform.position = target.position + offset;
    }
}
