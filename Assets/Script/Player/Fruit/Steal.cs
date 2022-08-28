using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Steal : MonoBehaviour
{
    public GameObject CanvasSteal;
    

    public void Onclick_Player()
    {
       BoatScript.instanceBoat.Playerpoint -= 1;
        //PointPlayer.instantiatepp.scoreplayer1 += 1;
        CanvasSteal.SetActive(false);
        CheckFruit.instantiateCheckfruit.PlayerStay = false;
    }
}
