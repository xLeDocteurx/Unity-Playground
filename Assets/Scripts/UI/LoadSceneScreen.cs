using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScreen : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;

    public void Start()
    {
        SceneManager.LoadScene(this.sceneToLoad);
    }
}
