using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFree : MonoBehaviour
{
    public GameObject buttonCanvas;
    public void FreeEffect()
    {
        buttonCanvas.SetActive(true);
    }
}
