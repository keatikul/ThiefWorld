using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gobacktomain : MonoBehaviour
{
    public void OnClick_Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
