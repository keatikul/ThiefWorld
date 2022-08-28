using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFall : MonoBehaviour
{
    public bool PlayerStay = false;
    public static FruitFall instantiateFruitFall;
    void Start()
    {
        MakeSingleton();
    }
    void MakeSingleton()
    {
        if (instantiateFruitFall == null)
        {
            instantiateFruitFall = this;
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
