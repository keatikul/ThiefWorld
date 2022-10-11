using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBot : MonoBehaviour
{
    public int player2 = 1;
    public int player3 = 1;
    public int player4 = 1;
    public Renderer CharacterPlayer2;
    public Renderer CharacterPlayer3;
    public Renderer CharacterPlayer4;

    public Material mattdefault;
    public void OnClick_Bot2()
    {
        player2 = 0;
        
        CharacterPlayer2.material = mattdefault; 
    }
    public void OnClick_Bot3()
    {
        player3 = 0;
        
        CharacterPlayer3.material = mattdefault;
    }
    public void OnClick_Bot4()
    {
        player4 = 0;
        
        CharacterPlayer4.material = mattdefault;
    }

    private void Update()
    {
        PlayerPrefs.SetInt("BotPlayer2", player2);
        PlayerPrefs.SetInt("BotPlayer3", player3);
        PlayerPrefs.SetInt("BotPlayer4", player4);
    }
}
