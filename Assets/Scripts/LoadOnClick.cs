using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void LoadScene(string level) {
        Debug.Log("Loading Level: " + level);
        SceneManager.LoadScene(level);
    }
}
