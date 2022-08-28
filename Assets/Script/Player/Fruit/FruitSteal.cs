using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitSteal : MonoBehaviour
{
    public bool PlayerStay = false;
    //public GameObject canvasSteal;
    public static FruitSteal instantiateFruitSteal;
    void Start()
    {
        MakeSingleton();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (PlayerStay == true)
        {
            canvasSteal.SetActive(true);
        }
        if (PlayerStay == false)
        {
            canvasSteal.SetActive(false);
        }*/
    }

    void MakeSingleton()
    {
        if (instantiateFruitSteal == null)
        {
            instantiateFruitSteal = this;
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
