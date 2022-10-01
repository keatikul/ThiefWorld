using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFruit : MonoBehaviour
{
    //public GameObject FruitSteal;
    public bool PlayerStay;
    public string FruitName;
    public static CheckFruit instantiateCheckfruit;
    //public GameObject CheckfruitCollider;
    //public BoxCollider _CheckfruitCollider;

    public void Start()
    {
        MakeSingleton();
        Debug.Log("Script check fruit start");
    }
    void MakeSingleton()
    {
        if (instantiateCheckfruit == null)
        {
            instantiateCheckfruit = this;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "apple(Clone)" || other.gameObject.name == "avocado(Clone)" || other.gameObject.name == "banana(Clone)" || other.gameObject.name == "cherries(Clone)" || other.gameObject.name == "lemon(Clone)" || other.gameObject.name == "peach(Clone)" || other.gameObject.name == "peanut(Clone)" || other.gameObject.name == "pear(Clone)" || other.gameObject.name == "strawberry(Clone)" || other.gameObject.name == "watermelon(Clone)" || other.gameObject.name == "Pineapple(Clone)")
        {
            if (Boat.instanceBoatt.isMoving == false) 
            { 
                PlayerStay = true;
                FruitName = other.gameObject.name;
            }
        }
        else
        {
            Debug.Log("Error");
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "apple(Clone)" || other.gameObject.name == "avocado(Clone)" || other.gameObject.name == "banana(Clone)" || other.gameObject.name == "cherries(Clone)" || other.gameObject.name == "lemon(Clone)" || other.gameObject.name == "peach(Clone)" || other.gameObject.name == "peanut(Clone)" || other.gameObject.name == "pear(Clone)" || other.gameObject.name == "strawberry(Clone)" || other.gameObject.name == "watermelon(Clone)" || other.gameObject.name == "Pineapple(Clone)" && Boat.instanceBoatt.isMoving == true)
        {
            PlayerStay = false;
        }
    }
}