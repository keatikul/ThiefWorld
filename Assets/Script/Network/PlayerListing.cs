using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;

public class PlayerListing : MonoBehaviour
{
    [SerializeField]
    private Text _text;
    private Player _player;

    public void SetPlayerInfo(Player player)
    {
        _player = player;
        _text.text = player.NickName;
    }
}
