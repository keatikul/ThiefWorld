using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkSpawnPlayer : MonoBehaviourPunCallbacks
{
    private GameObject spawnPlayerObject;
    private GameObject playerObj;
    private GameObject cameraObj;
    public Vector3 offset;
    public static NetworkSpawnPlayer instantiateNWS;
    public bool MyfunctionCalled = false;

    //public GameObject[] playerPrefabs;

    private void Start() {

      
        MakeSingleton();
        if (PhotonNetwork.IsConnected)
        {
            OnJoinedRoom();
        }    
        
    }
   
    private void Update()
    {

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
        Debug.Log("OnJoinedRoom");
        base.OnJoinedRoom();
       
        spawnPlayerObject = PhotonNetwork.Instantiate("Player", transform.position, transform.rotation);
        Debug.Log("1 Object name:"+ spawnPlayerObject.name);
        spawnPlayerObject.name = "master";
        Debug.Log("2 Object name:" + spawnPlayerObject.name);
        playerObj = spawnPlayerObject;
        cameraObj = Camera.main.gameObject;
        cameraObj.transform.position = playerObj.transform.position;
    }



    public override void OnLeftRoom(){
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnPlayerObject);
    }
}
