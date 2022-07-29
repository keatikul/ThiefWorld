using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class Gobacktomain : MonoBehaviourPunCallbacks
{
    public void OnClick_Back()
    {
        PhotonNetwork.LoadLevel(0);
        OnLeftLobby();
    }
}
