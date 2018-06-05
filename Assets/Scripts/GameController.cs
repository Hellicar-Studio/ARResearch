using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject Gui;
    // Use this for initialization
    private void Awake()
    {
        if(FindObjectOfType<LoadOnClick>() == null) {
            Instantiate(Gui);
        }
    }
}
