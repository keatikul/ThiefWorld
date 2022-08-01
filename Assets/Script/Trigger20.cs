using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger20 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public bool PlayerStay = false;
    public GameObject canvas;


    // Update is called once per frame
    void Update()
    {
        if (PlayerStay == true)
        {
            canvas.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerStay = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerStay = false;
        }
    }
}