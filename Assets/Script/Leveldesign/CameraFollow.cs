using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{   
    public CameraFollow cam;
    public Transform[] target;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;
    


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

                //transform.LookAt(target[i]);
            }
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn2 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[i].number == 2)
            {
                Vector3 desiredPosition = target[i].position + offset;
                Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
                transform.position = smoothPosition;
                //transform.LookAt(target[i]);
            }
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn3 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[i].number == 3)
            {
                Vector3 desiredPosition = target[i].position + offset;
                Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
                transform.position = smoothPosition;
                //transform.LookAt(target[i]);
            }
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn4 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[i].number == 4)
            {
                Vector3 desiredPosition = target[i].position + offset;
                Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
                transform.position = smoothPosition;
                //transform.LookAt(target[i]);
            }
        }
        
    }
}
