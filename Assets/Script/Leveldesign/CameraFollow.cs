using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{   
    public CameraFollow cam;
    public Transform[] target;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;
    public GameObject _cam;
    


    void Start() 
    {
        
        //cam = GameObject.FindGameObjectsWithTag("Player");
    }
    // Update is called once per frame
    void LateUpdate()
    {
        /*Vector3 desiredPosition = target[0].position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition;*/
        CamerafollowWithTurn();
    }

    public void CamerafollowWithTurn()
    {
        for (int i = 0; i < target.Length; i++)
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[i].number == 1)
            {
                Vector3 desiredPosition = target[i].position + offset;
                Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
                transform.position = smoothPosition;
                /*if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 18)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 90f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 90f, transform.eulerAngles.z);
                    //base oofset
                    // x -1.86 y 11.23 z -16.84
                    offset = new Vector3(17.4f, 11.23f, -2.21f); // y-270
                    
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 31)
                {
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 40)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 0f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 0f, transform.eulerAngles.z);
                    offset = new Vector3(2.1f, 11.23f, 24f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 45)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 180f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, -90f, transform.eulerAngles.z);
                    offset = new Vector3(15.97f, 11.23f, 0.3f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 60)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 45f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 45f, transform.eulerAngles.z);
                    offset = new Vector3(19.44f, 11.23f, 0.3f);

                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 64)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 90f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 90f, transform.eulerAngles.z);
                    offset = new Vector3(19.44f, 11.23f, 0.3f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 74)
                {
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 79)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, -180f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, -180f, transform.eulerAngles.z);
                    offset = new Vector3(-19.1f, 11.23f, 0.3f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 96)
                {
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }*/
                //transform.LookAt(target[i]);
            }
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[i].number == 2)
            {
                Vector3 desiredPosition = target[i].position + offset;
                Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
                transform.position = smoothPosition;
                /*if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 18)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 90f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 90f, transform.eulerAngles.z);
                    //base oofset
                    // x -1.86 y 11.23 z -16.84
                    offset = new Vector3(17.4f, 11.23f, -2.21f); // y-270

                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 31)
                {
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 40)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 0f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 0f, transform.eulerAngles.z);
                    offset = new Vector3(2.1f, 11.23f, 24f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 45)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 180f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, -90f, transform.eulerAngles.z);
                    offset = new Vector3(15.97f, 11.23f, 0.3f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 60)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 45f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 45f, transform.eulerAngles.z);
                    offset = new Vector3(19.44f, 11.23f, 0.3f);

                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 64)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 90f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 90f, transform.eulerAngles.z);
                    offset = new Vector3(19.44f, 11.23f, 0.3f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 74)
                {
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 79)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, -180f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, -180f, transform.eulerAngles.z);
                    offset = new Vector3(-19.1f, 11.23f, 0.3f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 96)
                {
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }*/
                //transform.LookAt(target[i]);
            }
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[i].number == 3)
            {
                Vector3 desiredPosition = target[i].position + offset;
                Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
                transform.position = smoothPosition;
                /*if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 18)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 90f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 90f, transform.eulerAngles.z);
                    //base oofset
                    // x -1.86 y 11.23 z -16.84
                    offset = new Vector3(17.4f, 11.23f, -2.21f); // y-270

                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 31)
                {
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 40)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 0f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 0f, transform.eulerAngles.z);
                    offset = new Vector3(2.1f, 11.23f, 24f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 45)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 180f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, -90f, transform.eulerAngles.z);
                    offset = new Vector3(15.97f, 11.23f, 0.3f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 60)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 45f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 45f, transform.eulerAngles.z);
                    offset = new Vector3(19.44f, 11.23f, 0.3f);

                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 64)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 90f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 90f, transform.eulerAngles.z);
                    offset = new Vector3(19.44f, 11.23f, 0.3f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 74)
                {
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 79)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, -180f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, -180f, transform.eulerAngles.z);
                    offset = new Vector3(-19.1f, 11.23f, 0.3f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 96)
                {
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }*/
                //transform.LookAt(target[i]);
            }
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[i].number == 4)
            {
                Vector3 desiredPosition = target[i].position + offset;
                Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
                transform.position = smoothPosition;
                /*if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 18)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 90f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 90f, transform.eulerAngles.z);
                    //base oofset
                    // x -1.86 y 11.23 z -16.84
                    offset = new Vector3(17.4f, 11.23f, -2.21f); // y-270

                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 31)
                {
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 40)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 0f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 0f, transform.eulerAngles.z);
                    offset = new Vector3(2.1f, 11.23f, 24f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 45)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 180f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, -90f, transform.eulerAngles.z);
                    offset = new Vector3(15.97f, 11.23f, 0.3f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 60)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 45f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 45f, transform.eulerAngles.z);
                    offset = new Vector3(19.44f, 11.23f, 0.3f);

                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 64)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, 90f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 90f, transform.eulerAngles.z);
                    offset = new Vector3(19.44f, 11.23f, 0.3f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 74)
                {
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 79)
                {
                    //transform.rotation = Quaternion.Euler(-201.023f, -180f, 179.375f);
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, -180f, transform.eulerAngles.z);
                    offset = new Vector3(-19.1f, 11.23f, 0.3f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                if (TurnScriptSinglePlay.instantiateTurnsingle.Players[i].routePosition >= 96)
                {
                    transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }
                else
                {
                    //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
                    offset = new Vector3(-1.86f, 11.23f, -16.84f);
                }*/
                //transform.LookAt(target[i]);
            }
        }
        
    }
}
