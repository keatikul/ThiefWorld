using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecivedataBot : MonoBehaviour
{
    public int player2status;
    public int player3status;
    public int player4status;

    public static RecivedataBot InstanceRecive;

 
    void Start()
    {
        player2status = PlayerPrefs.GetInt("BotPlayer2");
        player3status = PlayerPrefs.GetInt("BotPlayer3");
        player4status = PlayerPrefs.GetInt("BotPlayer4");
        MakeSingleton();
    }

    public void MakeSingleton()
    {
        if (InstanceRecive == null)
        {
            InstanceRecive = this;
        }
    }

    public void CheckStatus()
    {
        if (player2status == 1)
        {
            TurnScriptSinglePlay.instantiateTurnsingle.Players[1].Bot = true;
        }
        if (player3status == 1)
        {
            TurnScriptSinglePlay.instantiateTurnsingle.Players[2].Bot = true;
        }
        if (player4status == 1)
        {
            TurnScriptSinglePlay.instantiateTurnsingle.Players[3].Bot = true;
        }
    }


    void Update()
    {
        CheckStatus();
    }
}
