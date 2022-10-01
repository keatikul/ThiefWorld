using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class TextPosition : MonoBehaviour
{
    public Text positionText1;
    public Text positionText2;
    public Text positionText3;
    public Text positionText4;
    public PhotonView photonView;
    public Text otherText1;
    public Text otherText2;
    public Text otherText3;
    public Text otherText4;

    // Start is called before the first frame update
    void Start()
    {
        /*Debug.Log("TextPosition Start");
        if (BoatScript.instanceBoat.photonView == null)
        {
            Debug.Log("Photon view not found");
        }*/
        //photonView = GetComponent<PhotonView>();
        PhotonNetwork.AutomaticallySyncScene = true;
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.MasterClient.Get(1);
        }
    }

    // Update is called once per frame
    void Update()
    {

        photonView = GetComponent<PhotonView>();
        //photonView = BoatScript.instanceBoat.photonView;
        if (BoatScript.instanceBoat != null)
        { 
            if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
            {
            positionText1.text = BoatScript.instanceBoat.routePosition.ToString();
            photonView.RPC("UpdateText", RpcTarget.All, positionText1);
            }
            if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
            {
            //positionText2.text = BoatScript.instanceBoat.routePosition.ToString();
            photonView.RPC("UpdateText2", RpcTarget.All, null);
            }
            if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
            {
            positionText3.text = BoatScript.instanceBoat.routePosition.ToString();
            photonView.RPC("UpdateText", RpcTarget.Others, positionText3);
            }
            if (PhotonNetwork.LocalPlayer.ActorNumber == 4)
            {
            positionText4.text = BoatScript.instanceBoat.routePosition.ToString();
            photonView.RPC("UpdateText", RpcTarget.Others, positionText4);
            }
        }
        
        //positionText.text = BoatScript.instanceBoat.routePosition.ToString();
        /*if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            positionText1.text = BoatScript.instanceBoat.routePosition.ToString();
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            positionText2.text = BoatScript.instanceBoat.routePosition.ToString();
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            positionText3.text = BoatScript.instanceBoat.routePosition.ToString();
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 4)
        {
            positionText4.text = BoatScript.instanceBoat.routePosition.ToString();
        }*/
    }

    /*void UpdatePos(string pos)
    {
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            positionText1.text = BoatScript.instanceBoat.routePosition.ToString();
            photonView.RPC("UpdateText", RpcTarget.Others, positionText1);
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            positionText2.text = BoatScript.instanceBoat.routePosition.ToString();
            photonView.RPC("UpdateText", RpcTarget.Others, positionText2);
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            positionText3.text = BoatScript.instanceBoat.routePosition.ToString();
            photonView.RPC("UpdateText", RpcTarget.Others, positionText3);
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 4)
        {
            positionText4.text = BoatScript.instanceBoat.routePosition.ToString();
            photonView.RPC("UpdateText", RpcTarget.Others, positionText4);
        }*/
    
    [PunRPC]
    void UpdateText(string otherText1,string otherText2)
    {
        //PhotonView photonView = PhotonView.Get(this);
        photonView.RPC("UpdateText", RpcTarget.All);
        positionText1.text = BoatScript.instanceBoat.routePosition.ToString();
    }
}
