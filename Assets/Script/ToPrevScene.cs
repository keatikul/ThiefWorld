using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPrevScene : MonoBehaviour
{
    private int prevSceneToLoad;

    private void Start()
    {
        prevSceneToLoad = SceneManager.GetActiveScene().buildIndex - 1;
    }


    public void LoadprevScene()
    {
        SceneManager.LoadScene(prevSceneToLoad);
    }
}
