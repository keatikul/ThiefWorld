using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteScript : MonoBehaviour
{
    public static RouteScript instanceRoute;
    Transform[] childObject;
    public List<Transform> childNodeList = new List<Transform>();

    void Awake()
    {
        MakeSingletonRoute();
    }
    void MakeSingletonRoute()
    {
        if (instanceRoute == null)
        {
            instanceRoute = this;
        }
    }
    void OnDrawGizmos() {
        Gizmos.color = Color.green;

        FillNode();
        for (int i = 0; i < childNodeList.Count ; i++)
        {
            Vector3 currentPos = childNodeList[i].position;
            if(i>0)
            {
                Vector3 prevPos = childNodeList[i-1].position;
                Gizmos.DrawLine(prevPos, currentPos);
            }
        }
    }

    void FillNode()
    {
        childNodeList.Clear();
        childObject = GetComponentsInChildren<Transform>();
        foreach (Transform child in childObject)
        {
            if (child != this.transform)
            {
                childNodeList.Add(child);
            }
        }
    }
}
