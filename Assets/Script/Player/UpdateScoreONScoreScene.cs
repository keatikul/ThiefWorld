using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreONScoreScene : MonoBehaviour
{
    public Text scoreP1;
    public Text scoreP2;
    public Text scoreP3;
    public Text scoreP4;

    public List<int> scores = new List<int>();

    public int score1;
    public int score2;
    public int score3;
    public int score4;

    public int highScore;
    public int SecoundScore;
    public int ThirdScore;
    public int FourthScore;
    private void Start()
    {
        //Debug.Log(PlayerPrefs.GetInt("PointPlayer1"));
        score1 = PlayerPrefs.GetInt("PointPlayer1");
        score2 = PlayerPrefs.GetInt("PointPlayer2");
        score3 = PlayerPrefs.GetInt("PointPlayer3");
        score4 = PlayerPrefs.GetInt("PointPlayer4");

        
        scores.Add(score1);
        scores.Add(score2);
        scores.Add(score3);
        scores.Add(score4);
        SortingScore();
    }

    /*private void Update()
    {
        SortingScore();
    }*/

    public void SortingScore()
    {
        scores.Sort();
        for (int i = 0; i < scores.Count; i++)
        {
            if (scores[0] > scores[1])
            {
                highScore = scores[0];
                //SecoundScore = scores[1];
            }
            else
            {
                highScore = scores[1];
                //SecoundScore = scores[0];
            }
            if (highScore < scores[2])
            {
                highScore = scores[2];
            }
            if (highScore < scores[3])
            {
                highScore = scores[3];
            }

            if (scores[i] < highScore)
            {
                SecoundScore = scores[i];
            }
            else
            {
                highScore = scores[i];
            }


            /*if (scores[i] < SecoundScore)
            {
                ThirdScore = scores[i];
            }
            else
            {
                if (scores[i] > highScore)
                {
                    highScore = scores[i];
                }
                if (scores[i] > SecoundScore && scores[i] > highScore)
                {

                }

            }
            if (scores[i] < ThirdScore)
            {
                FourthScore = scores[i];
            }*/



            /*if (highScore == scores[i])
            {
                
            }*/

            
        }
        CheckWhowon();
        
        scoreP1.text = score1.ToString();
        scoreP2.text = score2.ToString();
        scoreP3.text = score3.ToString();
        scoreP4.text = score4.ToString();
        /*Debug.Log("Element0: " + scores[0]);
        Debug.Log("Element1: " + scores[1]);
        Debug.Log("Element2: " + scores[2]);
        Debug.Log("Element3: " + scores[3]);*/
        /*for (int i = 0; i < scores.Count; i++)
        {
            
        }*/
    }

    public void CheckWhowon()
    {
        
            
            {
                if (scores[3] == score1)
                {
                    Debug.Log("Player 1 win");
                }
                if (scores[3] == score2)
                {
                    Debug.Log("Player 2 win");
                }
                if (scores[3] == score3)
                {
                    Debug.Log("Player 3 win");
                }
                if (scores[3] == score4)
                {
                    Debug.Log("Player 4 win");
                }
            }
            /*else
            {
                Debug.Log("1 : " + scores[3] + " 2 :" + scores[i]);
            }*/
        





            
            {
                if (scores[2] == score1)
                {
                    Debug.Log("Player 1 2nd");
                }
                if (scores[2] == score2)
                {
                    Debug.Log("Player 2 2nd");
                }
                if (scores[2] == score3)
                {
                    Debug.Log("Player 3 2nd");
                }
                if (scores[2] == score4)
                {
                    Debug.Log("Player 4 2nd");
                }
            }
            /*else
            {
                Debug.Log("1 : " + scores[2] + " 2 :" + scores[i]);
            }*/
                


            if (scores[1] == score1)
            {
                Debug.Log("Player 1 3rd");
            }
            if (scores[1] == score2)
            {
                Debug.Log("Player 2 3rd");
            }
            if (scores[1] == score3)
            {
                Debug.Log("Player 3 3rd");
            }
            if (scores[1] == score4)
            {
                Debug.Log("Player 4 3rd");
            }



            if (scores[0] == score1)
            {
                Debug.Log("Player 1 4th");
            }
            if (scores[0] == score2)
            {
                Debug.Log("Player 2 4th");
            }
            if (scores[0] == score3)
            {
                Debug.Log("Player 3 4th");
            }
            if (scores[0] == score4)
            {
                Debug.Log("Player 4 4th");
            }
        }
    
    }
