using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateScoreONScoreScene : MonoBehaviour
{
    public TextMeshProUGUI scoreP1;
    public TextMeshProUGUI scoreP2;
    public TextMeshProUGUI scoreP3;
    public TextMeshProUGUI scoreP4;

    public TextMeshProUGUI Playerwon;
    public TextMeshProUGUI Playersecound;
    public TextMeshProUGUI PlayerThird;
    public TextMeshProUGUI PlayerForth;

    public List<int> scores = new List<int>();
    public List<string> Place = new List<string>();

    public int score1;
    public int score2;
    public int score3;
    public int score4;

    

    public int highScore;
    public int SecoundScore;
    public int ThirdScore;
    public int FourthScore;

    public bool FillName1;
    public bool FillName2;
    public bool FillName3;
    public bool FillName4;

    public GameObject Cha1;
    public GameObject Cha2;
    public GameObject Cha3;
    public GameObject Cha4;

    public GameObject Cha21;
    public GameObject Cha22;
    public GameObject Cha23;
    public GameObject Cha24;

    public GameObject Cha31;
    public GameObject Cha32;
    public GameObject Cha33;
    public GameObject Cha34;

    public GameObject Cha41;
    public GameObject Cha42;
    public GameObject Cha43;
    public GameObject Cha44;
    private void Start()
    {
        //Debug.Log(PlayerPrefs.GetInt("PointPlayer1"));
        score1 = PlayerPrefs.GetInt("PointPlayer1");
        score2 = PlayerPrefs.GetInt("PointPlayer2");
        score3 = PlayerPrefs.GetInt("PointPlayer3");
        score4 = PlayerPrefs.GetInt("PointPlayer4");

        /*score1 = 36;
        score2 = 3;
        score3 = 2;
        score4 = 5;*/



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
        //CheckWon();
        
        /*scoreP1.text = score1.ToString();
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
        if (scores[3] == score1)
        {
          //Debug.Log("Player 1 win");
          //Playerwon.text = "Player 1";
          scoreP1.text = scores[3].ToString();
          FillName1 = true;
            //Cha1.SetActive(true);
            Place.Add("Player1");
        }
        if (scores[3] == score2)
        {
          //Debug.Log("Player 2 win");
          //Playerwon.text = "Player 2";
          scoreP1.text = scores[3].ToString();
            FillName1 = true;
            //Cha2.SetActive(true);
            Place.Add("Player2");
        }
        if (scores[3] == score3)
        {
          //Debug.Log("Player 3 win");
          //Playerwon.text = "Player 3";
          scoreP1.text = scores[3].ToString();
            FillName1 = true;
            //Cha3.SetActive(true);
            Place.Add("Player3");
        }
        if (scores[3] == score4)
        {
          //Debug.Log("Player 4 win");
          //Playerwon.text = "Player 4";
          scoreP1.text = scores[3].ToString();
            FillName1 = true;
            //Cha4.SetActive(true);
            Place.Add("Player4");
        }
        



        if (scores[2] == score1 && Place[0] != "Player1")
        {
            //Debug.Log("Player 1 2nd");
            //Playersecound.text = "Player 1";
            scoreP2.text = scores[2].ToString();
            FillName2 = true;
            //Cha21.SetActive(true);
            Place.Add("Player1");
        }
        if (scores[2] == score2 && Place[0] != "Player2")
        {
             //Debug.Log("Player 2 2nd");
             //Playersecound.text = "Player 2";
             scoreP2.text = scores[2].ToString();
            FillName2 = true;
            //Cha22.SetActive(true);
            Place.Add("Player2");
        }
        if (scores[2] == score3 && Place[0] != "Player3")
        {
             //Debug.Log("Player 3 2nd");
             //Playersecound.text = "Player 3";
             scoreP2.text = scores[2].ToString();
            FillName2 = true;
            //Cha23.SetActive(true);
            Place.Add("Player3");
        }
        if (scores[2] == score4 && Place[0] != "Player4")
        {
             //Playersecound.text = "Player 4";
             //Debug.Log("Player 4 2nd");
             scoreP2.text = scores[2].ToString();
            FillName2 = true;
            //Cha24.SetActive(true);
            Place.Add("Player4");
        }
        

     
        if (scores[1] == score1 && Place[1] != "Player1" && Place[0] != "Player1")
        {
            //Debug.Log("Player 1 3rd");
            //PlayerThird.text = "Player 1";
            scoreP3.text = scores[1].ToString();
                FillName3 = true;
                //Cha31.SetActive(true);
            Place.Add("Player1");
        }
        if (scores[1] == score2 && Place[1] != "Player2" && Place[0] != "Player2")
        {
            //Debug.Log("Player 2 3rd");
            //PlayerThird.text = "Player 2";
            scoreP3.text = scores[1].ToString();
                FillName3 = true;
                //Cha32.SetActive(true);
            Place.Add("Player2");
        }
        if (scores[1] == score3 && Place[1] != "Player3" && Place[0] != "Player3" )
        {
            //Debug.Log("Player 3 3rd");
            //PlayerThird.text = "Player 3";
            scoreP3.text = scores[1].ToString();
                FillName3 = true;
                //Cha33.SetActive(true);
            Place.Add("Player3");
        }
        if (scores[1] == score4 && Place[1] != "Player4" && Place[0] != "Player4")
        {
            //Debug.Log("Player 4 3rd");
            //PlayerThird.text = "Player 4";
            scoreP3.text = scores[1].ToString();
                FillName3 = true;
                //Cha34.SetActive(true);
            Place.Add("Player4");
        }
        




        if (scores[0] == score1 && Place[1] != "Player1" && Place[0] != "Player1" && Place[2] != "Player1")
        {
            //Debug.Log("Player 1 4th");
            //PlayerForth.text = "Player 1";
            scoreP4.text = scores[0].ToString();
                FillName4 = true;
                //Cha41.SetActive(true);
            Place.Add("Player1");
        }
        if (scores[0] == score2 && Place[1] != "Player2" && Place[0] != "Player2" && Place[2] != "Player2")
        {
            //Debug.Log("Player 2 4th");
            //PlayerForth.text = "Player 2";
            scoreP4.text = scores[0].ToString();
                FillName4 = true;
                //Cha42.SetActive(true);
            Place.Add("Player2");
        }
        if (scores[0] == score3 && Place[1] != "Player3" && Place[0] != "Player3" && Place[2] != "Player3")
        {
            //Debug.Log("Player 3 4th");
            //PlayerForth.text = "Player 3";
            scoreP4.text = scores[0].ToString();
                FillName4 = true;
                //Cha43.SetActive(true);
            Place.Add("Player3");
        }
        if (scores[0] == score4 && Place[1] != "Player4" && Place[0] != "Player4" && Place[2] != "Player4")
        {
            //Debug.Log("Player 4 4th");
            //PlayerForth.text = "Player 4";
            scoreP4.text = scores[0].ToString();
                FillName4 = true;
                //Cha44.SetActive(true);
            Place.Add("Player4");
        }
        
        highScore = scores[3];
        SecoundScore = scores[2];
        ThirdScore = scores[1];
        FourthScore = scores[0];

        Playerwon.text = Place[0];
        Playersecound.text = Place[1];
        PlayerThird.text = Place[2];
        PlayerForth.text = Place[3];
        /*for (int i = 0; i < 4; i++)
        {
            if (Place[0] != Place[i])
            {
                Playerwon.text = Place[0];
            }
            if (Place[1] != Place[i])
            {
                Playersecound.text = Place[1];
            }
            else
            {
                Place.RemoveAt(i);
            }
            if (Place[2] != Place[i])
            {
                PlayerThird.text = Place[2];
            }
            else
            {
                Place.RemoveAt(i);
            }
            if (Place[3] != Place[i])
            {
                PlayerForth.text = Place[3];
            }
            else
            {
                Place.RemoveAt(i);
            }
        }*/

        if (Playerwon.text == "Player1")
        {
            Cha1.SetActive(true);
        }
        if (Playerwon.text == "Player2")
        {
            Cha2.SetActive(true);
        }
        if (Playerwon.text == "Player3")
        {
            Cha3.SetActive(true);
        }
        if (Playerwon.text == "Player4")
        {
            Cha4.SetActive(true);
        }


        if (Playersecound.text == "Player1")
        {
            Cha21.SetActive(true);
        }
        if (Playersecound.text == "Player2")
        {
            Cha22.SetActive(true);
        }
        if (Playersecound.text == "Player3")
        {
            Cha23.SetActive(true);
        }
        if (Playersecound.text == "Player4")
        {
            Cha24.SetActive(true);
        }


        if (PlayerThird.text == "Player1")
        {
            Cha31.SetActive(true);
        }
        if (PlayerThird.text == "Player2")
        {
            Cha32.SetActive(true);
        }
        if (PlayerThird.text == "Player3")
        {
            Cha33.SetActive(true);
        }
        if (PlayerThird.text == "Player4")
        {
            Cha34.SetActive(true);
        }

        if (PlayerForth.text == "Player1")
        {
            Cha41.SetActive(true);
        }
        if (PlayerForth.text == "Player2")
        {
            Cha42.SetActive(true);
        }
        if (PlayerForth.text == "Player3")
        {
            Cha43.SetActive(true);
        }
        if (PlayerForth.text == "Player4")
        {
            Cha44.SetActive(true);
        }




    }
    

    public void CheckWon()
    {
        for (int i = 0; i < scores.Count; i++)
        {
            for (int j = 0; j < scores.Count; j++)
            {
                if (scores[i] == scores[j])
                {
                    Debug.Log("isthesame");
                }
            }
            
        }
    }
    }
