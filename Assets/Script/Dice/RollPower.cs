using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollPower : MonoBehaviour
{
    public static RollPower instanceRollPw;
    public Image imagepowerUp;
    //public DiceScript diceSc;
    public float holddownStarttime = 0f;
    bool buttonHoldDown = false;
    public float power;
    public float maxtimer = 2f;

    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        //diceSc = GameObject.Find("Dice").GetComponent<DiceScript>();
        imagepowerUp.fillAmount = 0;
        MakeSingletonRoll();
    }

    void MakeSingletonRoll()
    {
        if (instanceRollPw == null)
        {
            instanceRollPw = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonHoldDown == true)
        {
            //holddownStarttime += Time.deltaTime;
            if (holddownStarttime >= maxtimer)
            {
                holddownStarttime -= Time.deltaTime;
            }
            else
            {
                holddownStarttime += Time.deltaTime;
            }
            
        }
        if(holddownStarttime < 1)
        {
            power = 500;
        }else
        {
            power = 30;
        }

        if(buttonHoldDown == false)
        {
            holddownStarttime = 0;
        }
        imagepowerUp.fillAmount = holddownStarttime;
    }

    public void HoldButton()
    {
        buttonHoldDown = true;
        //imagepowerUp.fillAmount = (0 - 1) * holddownStarttime;
    }

    public void ReleaseButton()
    {
        buttonHoldDown = false;
        DiceScript.instance.Roll();
        //diceSc.Roll();
        //isRoll = true;
    }
}
