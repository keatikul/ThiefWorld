using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Boat : MonoBehaviour
{
    public bool Bot = false;


    public int Playerpoint;
    public int routePosition;
    public int steps;
    public bool isMoving;
    public static Boat instanceBoatt;
    private Camera cam;
    public int number;
    public int numberboat;

    public bool PlayerStay;
    public bool FinishGame;
    public string FruitName1;

    public GameObject canvasSteal;//Apple
    public GameObject canvasProtect;//Peanuts
    public GameObject canvasFall;//Watermelon
    public GameObject canvasStole;//Peach
    public GameObject canvasStolen;//Pear
    public GameObject canvasSiren;//Avocado
    public GameObject canvasFreeze;//Lemon
    public GameObject canvasFree;//Strawberry
    public GameObject canvasReverse;//Banana
    public GameObject canvasTime;//Cherrie

    public bool addplayerpoint;
    private bool checkloop = true;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI Position;

    public bool ProtectEffect;
    public bool SirenEffect;
    public bool FreezeEffect;

    public bool boolBotMove;

    public Vector3 offset;


    public GameObject iconSiren;
    public GameObject iconFreeze;
    public GameObject iconProtect;



    /*public GameObject iconFruit;
    public GameObject iconPosition;
    public Text fruittext;
    public Text positiontext;
    public GameObject g_icontext;*/



    void Start()
    {
        Debug.Log("Boat Script Start");
        //Debug.Log("Number turn:" + number);
        MakeSingleton();
        /*if (TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.activeSelf == false && TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true)
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(true);
        }*/
        //BotMove();
        
    }



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "apple(Clone)" || other.gameObject.name == "avocado(Clone)" || other.gameObject.name == "banana(Clone)" || other.gameObject.name == "cherries(Clone)" || other.gameObject.name == "lemon(Clone)" || other.gameObject.name == "peach(Clone)" || other.gameObject.name == "peanut(Clone)" || other.gameObject.name == "pear(Clone)" || other.gameObject.name == "strawberry(Clone)" || other.gameObject.name == "watermelon(Clone)" || other.gameObject.name == "Pineapple(Clone)")
        {
            PlayerStay = true;
            FruitName1 = other.gameObject.name;
            
        }
        //Debug.Log("isMoving: "+isMoving);
        //FruitName1 = other.gameObject.name;
        
        /*else
        {
            Debug.Log("Error");
        }*/

        /*if (FruitName1 == "Pineapple(Clone)")
        {
            Playerpoint += 1;
        }
        if (FruitName1 == "apple(Clone)")
        {
            Playerpoint += 1;
        }
        if (FruitName1 == "peanut(Clone)")
        {
            Playerpoint += 1;
        }
        if (FruitName1 == "watermelon(Clone)")
        {
            Playerpoint += 1;
        }
        if (FruitName1 == "peach(Clone)")
        {
            Playerpoint += 1;
        }
        if (FruitName1 == "pear(Clone)")
        {
            Playerpoint += 1;
        }*/
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "apple(Clone)" || other.gameObject.name == "avocado(Clone)" || other.gameObject.name == "banana(Clone)" || other.gameObject.name == "cherries(Clone)" || other.gameObject.name == "lemon(Clone)" || other.gameObject.name == "peach(Clone)" || other.gameObject.name == "peanut(Clone)" || other.gameObject.name == "pear(Clone)" || other.gameObject.name == "strawberry(Clone)" || other.gameObject.name == "watermelon(Clone)" || other.gameObject.name == "Pineapple(Clone)" && Boat.instanceBoatt.isMoving == true)
        {
            PlayerStay = false;
        }
    }



    void MakeSingleton()
    {
        if (instanceBoatt == null)
        {
            instanceBoatt = this;
        }
    }

    void Update()
    {
        if (SirenEffect == true)
        {
            iconSiren.SetActive(true);
        }
        else
        {
            iconSiren.SetActive(false);
        }
        if (FreezeEffect == true)
        {
            iconFreeze.SetActive(true);
        }
        else
        {
            iconFreeze.SetActive(false);
        }
        if (ProtectEffect == true)
        {
            iconProtect.SetActive(true);
        }
        else
        {
            iconProtect.SetActive(false);
        }
        if (numberboat == 1)
        {
            PlayerPrefs.SetInt("PointPlayer1", Playerpoint);
        }
        if (numberboat == 2)
        {
            PlayerPrefs.SetInt("PointPlayer2", Playerpoint);
        }
        if (numberboat == 3)
        {
            PlayerPrefs.SetInt("PointPlayer3", Playerpoint);
        }
        if (numberboat == 4)
        {
            PlayerPrefs.SetInt("PointPlayer4", Playerpoint);
        }

        if (isMoving == false)
        {
            steps = 0;
            //iconFruit.SetActive(false);

            //ActionFruit();
        }
        //CharacterMoveWithTurn();
        if (RouteScript.instanceRoute.childNodeList[routePosition].name == "Cube100(Finish)")
        {
            Playerpoint +=4;
            FinishGame = true;
            
            GotoScore();
        }
        Score.text = Playerpoint.ToString();
        Position.text = routePosition.ToString();

        
        

        if (RouteScript.instanceRoute.childNodeList[routePosition].name == "Cube100(Finish)")
        {
            //offset.x = 
        }
    }

    public void CharacterMoveWithTurn()
    {
        { 
            if (Bot == true && boolBotMove == false)
            {
                if (SirenEffect == false && FreezeEffect == false)
                {
                    //this.steps = 20;
                    this.steps = Random.Range(1, 7);
                    TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
                    StartCoroutine(BotMove(steps));
                    if (routePosition + steps <= RouteScript.instanceRoute.childNodeList.Count)
                    {
                        StartCoroutine(BotMove(steps));
                    }
                    else
                    {
                        Debug.Log("nani");
                    }
                } 
            }
            else
            {
                steps = PowerUp.instancePowerUp.dicepoint;
                
            }
            //Debug.Log("Dice Roll" + steps);
            StartCoroutine(Move(steps));
            if (routePosition + steps <= RouteScript.instanceRoute.childNodeList.Count)
            {
                StartCoroutine(Move(steps));
            }
            else
            {
                Debug.Log("nani");
            }
            
        }
            
    }

    public void BotMove()
    {

        //this.steps = Random.Range(1, 7);
            steps = FruitFree.instancefruitFree.index;
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            StartCoroutine(BotMove(steps));
            if (routePosition + steps <= RouteScript.instanceRoute.childNodeList.Count)
            {
                StartCoroutine(BotMove(steps));
            }
            else
            {
                Debug.Log("nani");
            }
        
    }

    IEnumerator BotMove(int steps)
    {
        boolBotMove = true;
        if (isMoving)
        {
            PowerUp.instancePowerUp.dicepoint = 0;
            yield break;
        }
        isMoving = true;


        while (steps > 0)
        {
            Vector3 nextPos = RouteScript.instanceRoute.childNodeList[routePosition + 1].position;
            //Debug.Log(RouteScript.instanceRoute.childNodeList[routePosition + 1].name);
            transform.LookAt(nextPos);
            while (MovetoNextNode(nextPos)) { yield return null; }

            yield return //new WaitForSeconds(0.1f);
            steps -= 1;
            //Debug.Log("" + steps);
            routePosition++;
            checkloop = false;
        }

        isMoving = false;
    }

    public void MoveBack3()
    {
        if (routePosition > 2)
        {
            routePosition -= 3;

            Vector3 nextPos = RouteScript.instanceRoute.childNodeList[routePosition].position;
            transform.LookAt(nextPos);
            StartCoroutine(Movebackward3(nextPos));
        }
        else
        {
            Playerpoint -= 2;
            
        }
    }

    IEnumerator Movebackward3(Vector3 nextPos)
    {
        while (MovetoNextNode(nextPos)) { yield return null; }
        isMoving = false;
       

    }

    public void MoveBack()
    {
        if (routePosition > 1)
        {
            routePosition -= 2;
            
            Vector3 nextPos = RouteScript.instanceRoute.childNodeList[routePosition].position;
            transform.LookAt(nextPos);
            StartCoroutine(Movebackward(nextPos));
        }
        else
        {
            Playerpoint--;
            
        }
    }

    IEnumerator Movebackward(Vector3 nextPos)
    {
        while (MovetoNextNode(nextPos)) { yield return null; }
        isMoving = false;
        
    }

    public void StopMove()
    {
        steps = 0;
    }

    public void GotoScore()
    {
        SceneManager.LoadScene("Score");
    }

    IEnumerator Move(int steps)
    {
        if (isMoving)
        {
            PowerUp.instancePowerUp.dicepoint = 0;
            yield break;
        }
        isMoving = true;


        while (steps > 0)
        {
            Vector3 nextPos = RouteScript.instanceRoute.childNodeList[routePosition + 1].position;
            //Debug.Log(RouteScript.instanceRoute.childNodeList[routePosition + 1].name);
            transform.LookAt(nextPos);
            while (MovetoNextNode(nextPos)) { yield return null; }

            yield return //new WaitForSeconds(0.1f);
            steps -= 1;
            //Debug.Log("" + steps);
            routePosition++;
            checkloop = false;
        }

        isMoving = false;
        PowerUp.instancePowerUp.Rolltext.text = "Roll";
        TurnScriptSinglePlay.instantiateTurnsingle.buttoncanvasText.text = "Roll";
        if (steps == 0 && checkloop == false) 
        { 
            ActionFruit();
            checkloop = true;
        }
        
    }
    bool MovetoNextNode(Vector3 goal)
    {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 50f * Time.deltaTime));
    }

    public void ActionFruit()
    {
        //Playerpoint += 1;
        if (FruitName1 == "Pineapple(Clone)")
        {   
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            //Debug.Log("working");
            Playerpoint++;
            
            TurnScriptSinglePlay.instantiateTurnsingle.CheckPlayerNum();
        }
        if (FruitName1 == "apple(Clone)")
        {   
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            canvasSteal.SetActive(true);
            Playerpoint++;
            
        }
        if (FruitName1 == "peanut(Clone)")
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            canvasProtect.SetActive(true);
            Playerpoint++;
            
            ProtectEffect = true;

        }
        if (FruitName1 == "watermelon(Clone)")
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            canvasFall.SetActive(true);
            Playerpoint++;
            

        }
        if (FruitName1 == "peach(Clone)")
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            canvasStole.SetActive(true);
            Playerpoint++;
            

        }
        if (FruitName1 == "pear(Clone)")
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            canvasStolen.SetActive(true);
            Playerpoint++;
            

        }
        if (FruitName1 == "avocado(Clone)")
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            canvasSiren.SetActive(true);
            Playerpoint++;
           
            if (ProtectEffect == false)
            {
                SirenEffect = true;
            }
            else
            {
                SirenEffect = false;
            }


        }
        if (FruitName1 == "lemon(Clone)")
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            canvasFreeze.SetActive(true);
            Playerpoint++;
           
            if (ProtectEffect == false)
            {
                FreezeEffect = true;
            }
            else
            {
                FreezeEffect = false;
            }

        }
        if (FruitName1 == "strawberry(Clone)")
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            canvasFree.SetActive(true);
            Playerpoint++;
            
        }
        if (FruitName1 == "banana(Clone)")
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            canvasReverse.SetActive(true);
            Playerpoint++;
            
        }
        if (FruitName1 == "cherries(Clone)")
        {
            TurnScriptSinglePlay.instantiateTurnsingle.buttonCanvas.SetActive(false);
            canvasTime.SetActive(true);
            Playerpoint++;
            

        }

    }
    public void OnclickActionSteal()
    {
        PlayerStay = false;
        canvasSteal.SetActive(false);
        Timer.instantiateTimer.timeValue = 7;
    }
}

