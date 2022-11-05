using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    public Image imagePowerUp;
    public bool isPowerUp = false;
    private bool isDirectionUp = true;
    public float amtPower = 0.0f;
    private float powerSpeed = 100.0f;
    public int dicepoint;
    public static PowerUp instancePowerUp;
    public bool isRoll = false;
    //public bool moveBoat = false;
    public GameObject dice;
    public Vector3 rotation;
    public Material[] materials;
    Renderer rend;
    public int Matt;
    public Text Rolltext;

   
    void Awake()
    {
        Matt = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[Matt];
        MakeSingleton();
        //dice.SetActive(false);
    }
    void Update()
    {
        rend.sharedMaterial = materials[Matt];
        if (isPowerUp)
        {
            PowerActive();
            dicepoint = 0;
            
        }
        if (dicepoint <= 0 && amtPower == 0.0f && isPowerUp == false)
        {
            dicepoint = 0;
            isRoll = false;
            //StopRoll();
            //isRoll = false;
        }
        
        //Debug.Log("Amtpower" + amtPower);
        //DiceRoll();
    }
    void StopRoll()
    {
        dice.SetActive(false);
        dicepoint = 0;
        
    }

    void MakeSingleton()
    {
        if (instancePowerUp == null)
        {
            instancePowerUp = this;
        }
    }

    void DiceRoll()
    {
        if (amtPower >= 50f)
        {
            dicepoint = Random.Range(4, 7);
            Rolltext.text = dicepoint.ToString();
            //dicepoint = 100;
            //isRoll = true;
            Debug.Log("Dice" + dicepoint);
            ClearValue();
        }
        else
        {
            dicepoint = Random.Range(1, 4);
            Rolltext.text = dicepoint.ToString();
            //dicepoint = 1;
            NextMatterial();
            //isRoll = true;
            Debug.Log("Dice" + dicepoint);
            ClearValue();
        }
        

    }

    void NextMatterial()
    {
        if (dicepoint == 1)
        {
            Matt = 0;
        }
        if (dicepoint == 2)
        {
            Matt = 1;
        }
        if (dicepoint == 3)
        {
            Matt = 2;
        }
        if (dicepoint == 4)
        {
            Matt = 3;
        }
        if (dicepoint == 5)
        {
            Matt = 4;
        }
        if (dicepoint == 6)
        {
            Matt = 5;
        }
    }
    void ClearValue()
    {
        dice.SetActive(false);
        amtPower = 0.0f;
        imagePowerUp.fillAmount = 0;
        
    }

    void PowerActive()
    {
        if (isDirectionUp)
        {
            amtPower += Time.deltaTime * powerSpeed;
            if (amtPower > 100)
            {
                isDirectionUp = false;
                amtPower = 100.0f;
            }
        }
        else
        {
            amtPower -= Time.deltaTime * powerSpeed;
            if (amtPower < 0)
            {
                isDirectionUp = true;
                amtPower = 0.0f;
            }
        }
        imagePowerUp.fillAmount = (1f - 0f) * amtPower / 100.0f + 0f;
    }
    public void StartPowerUp()
    {
        isPowerUp = true;
        amtPower = 0.0f;
        isDirectionUp = true;
        if (isRoll == false)
        {
            Rolltext.text = "Roll";
        }
    }
    public void EndPowerUp()
    {   
        DiceRoll();
        isPowerUp = false;
        isRoll = true;
        dice.SetActive(true);
        dice.transform.position = new Vector3(-0.04694976f, 292f, -3.222631f);
        dice.transform.rotation = Quaternion.Euler(65f,3f,1.8f);

    }
}
