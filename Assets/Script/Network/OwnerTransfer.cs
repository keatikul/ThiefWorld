using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class OwnerTransfer : MonoBehaviourPunCallbacks
{
    private void Awake() {
        PhotonNetwork.AddCallbackTarget(this);
    }

    private void OnDestroy() {
        PhotonNetwork.RemoveCallbackTarget(this);
    }
    public void OnOwnershipRequest(PhotonView targetView, Player requestingPlayer)
    {
        if(targetView != base.photonView)
            return;
        
        //throw new System.NotImplementedException();
        base.photonView.TransferOwnership(requestingPlayer);
    }
    public void OnOwnershipTransferd(PhotonView targetView, Player previousOwner)
    {
        if(targetView != base.photonView)
            return;
        //throw new System.NotImplementedException();
    }

    private void OnMouseDown() {
        base.photonView.RequestOwnership();
    }
    
    
}
    