using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rota : MonoBehaviour
{
    public GameObject ship;
    //public Vector3 _rotation;
    //public float speed = 50f;
    public Transform target;
    public bool playerStay = false;

    // Update is called once per frame
    void Update()
    {
        if(playerStay == true)
        {
            ship.transform.localEulerAngles = new Vector3(0, -180, 0);
        }
        else
        {
            ship.transform.localEulerAngles = new Vector3(0, -90, 0);
        }
        
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player")
        {
            playerStay = true;
            //transform.Rotate(Vector3.left * speed * Time.deltaTime);
            //ship.transform.localEulerAngles = new Vector3(0, -180, 0);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerStay = false;
        }
    }
}
