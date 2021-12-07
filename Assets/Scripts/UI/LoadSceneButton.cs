using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;

    public void OnClick()
    {
        if(sceneToLoad == "Quit")
        {
            Application.Quit();
        } else
        {
            SceneManager.LoadScene(this.sceneToLoad);
        }
    }
}
