using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkSpawnPlayer : MonoBehaviourPunCallbacks
{

    private GameObject spawnPlayerObject;
    //private GameObject buttonRoll;
    private GameObject playerObj;
    private GameObject cameraObj;
    public Vector3 offset;
    public static NetworkSpawnPlayer instantiateNWS;
    

    void Start() {
        MakeSingleton();
        //Camera.main.transform.SetParent(spawnPlayerObject.transform);
        //Camera.main.gameObject.GetComponent<camaralook>().targget = spawnPlayerObject;
        if (PhotonNetwork.IsConnected)
        {
            Debug.Log("This Room is connected too");
            OnJoinedRoom();
        }
    }

    public void MakeSingleton()
    {
        if (instantiateNWS == null)
        {
            instantiateNWS = this;
        }
    }

    private void FixedUpdate()
    {
        if (playerObj != null && cameraObj != null)
        {
            cameraObj.transform.position = playerObj.transform.position - offset;
        }
    }
    public override void OnJoinedRoom(){
        base.OnJoinedRoom();
        spawnPlayerObject = PhotonNetwork.Instantiate("Player", transform.position, transform.rotation);
        spawnPlayerObject.name = "master";
        playerObj = spawnPlayerObject;
        cameraObj = Camera.main.gameObject;
        cameraObj.transform.position = playerObj.transform.position;
        //buttonRoll = PhotonNetwork.Instantiate("Button", transform.position, transform.rotation);
        
    }

    public override void OnLeftRoom(){
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnPlayerObject);
    }
}
