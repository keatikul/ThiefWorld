using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class camaralook : MonoBehaviour
{
    public GameObject targget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targget != null)
        {
            transform.LookAt(targget.transform);
        }
    }
}
