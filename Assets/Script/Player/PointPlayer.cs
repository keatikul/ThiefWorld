using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointPlayer : MonoBehaviour
{
    public List<Boat> boats = new List<Boat>();
    public static PointPlayer instantiatepp;
    public int pp_1;
    public int pp_2;
    public int pp_3;
    public int pp_4;
    public GameObject Manager;
    // Start is called before the first frame update
    void Start()
    {
        MakeSingleton();
        
    }
    void MakeSingleton()
    {
        if (instantiatepp == null)
        {
            instantiatepp = this;
        }
    }
    
    void Update()
    {
        pp_1 = boats[0].Playerpoint;
        pp_2 = boats[1].Playerpoint;
        pp_3 = boats[2].Playerpoint;
        pp_4 = boats[3].Playerpoint;
        SaveScore();
    }

    public void SaveScore()
    {
        for (int i = 0; i < boats.Count; i++)
        {
            if (boats[i].FinishGame == true)
            {
                PlayerPrefs.SetInt("PointPlayer1", pp_1);
                PlayerPrefs.SetInt("PointPlayer2", pp_2);
                PlayerPrefs.SetInt("PointPlayer3", pp_3);
                PlayerPrefs.SetInt("PointPlayer4", pp_1);
            }
            
        }
        
    }
}
