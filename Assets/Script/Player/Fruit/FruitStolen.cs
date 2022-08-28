using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitStolen : MonoBehaviour
{
    public bool PlayerStay = false;
    public static FruitStolen instantiateFruitStolen;
    void Start()
    {
        MakeSingleton();
    }
    void MakeSingleton()
    {
        if (instantiateFruitStolen == null)
        {
            instantiateFruitStolen = this;
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
