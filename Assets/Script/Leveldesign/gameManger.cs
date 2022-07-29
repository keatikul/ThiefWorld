using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManger : MonoBehaviour
{
    private static gameManger _instance;

    public static gameManger Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("gameManger");
                go.AddComponent<gameManger>();
            }
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }
}
