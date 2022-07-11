using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkSpawnPlayer : MonoBehaviourPunCallbacks
{
    private GameObject spawnPlayerObject;
    public override void OnJoinedRoom(){
        base.OnJoinedRoom();
        spawnPlayerObject = PhotonNetwork.Instantiate("Netizen Player", transform.position, transform.rotation);
        
    }

    public override void OnLeftRoom(){
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnPlayerObject);
    }
}
