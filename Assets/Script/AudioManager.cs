using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameObject Audio;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(Audio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
