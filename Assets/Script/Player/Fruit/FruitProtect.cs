using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitProtect : MonoBehaviour
{
    public bool PlayerStay = false;
    public static FruitProtect instantiateFruitProtect;
    void Start()
    {
        MakeSingleton();
    }
    void MakeSingleton()
    {
        if (instantiateFruitProtect == null)
        {
            instantiateFruitProtect = this;
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
