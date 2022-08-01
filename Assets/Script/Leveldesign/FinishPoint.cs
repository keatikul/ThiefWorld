using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviourPunCallbacks
{


    private void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (BoatScript.instanceBoat.steps == 40)
        {
            PhotonNetwork.LoadLevel(6);
        }
    }

}
