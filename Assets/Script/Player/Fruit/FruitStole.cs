using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitStole : MonoBehaviour
{
    public bool PlayerStay = false;
    public static FruitStole instantiateFruitStole;
    void Start()
    {
        MakeSingleton();
    }
    void MakeSingleton()
    {
        if (instantiateFruitStole == null)
        {
            instantiateFruitStole = this;
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
