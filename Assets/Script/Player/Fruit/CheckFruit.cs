using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFruit : MonoBehaviour
{
    //public GameObject FruitSteal;
    public bool PlayerStay = false;
    public string FruitName;
    public static CheckFruit instantiateCheckfruit;

    public void Start()
    {
        MakeSingleton();
    }
    void MakeSingleton()
    {
        if (instantiateCheckfruit == null)
        {
            instantiateCheckfruit = this;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "apple(Clone)" || other.gameObject.name == "avocado(Clone)" || other.gameObject.name == "banana(Clone)" || other.gameObject.name == "cherries(Clone)" || other.gameObject.name == "lemon(Clone)" || other.gameObject.name == "peach(Clone)" || other.gameObject.name == "peanut(Clone)" || other.gameObject.name == "pear(Clone)" || other.gameObject.name == "strawberry(Clone)" || other.gameObject.name == "watermelon(Clone)")
        {
            PlayerStay = true;
            FruitName = other.gameObject.name;
            
            //Debug.Log("is working"+FruitName);
            //FruitSteal.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "apple(Clone)" || other.gameObject.name == "avocado(Clone)" || other.gameObject.name == "banana(Clone)" || other.gameObject.name == "cherries(Clone)" || other.gameObject.name == "lemon(Clone)" || other.gameObject.name == "peach(Clone)" || other.gameObject.name == "peanut(Clone)" || other.gameObject.name == "pear(Clone)" || other.gameObject.name == "strawberry(Clone)" || other.gameObject.name == "watermelon(Clone)")
        {
            PlayerStay = false;
        }
    }
}