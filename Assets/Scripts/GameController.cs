using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class GameController : MonoBehaviour {

    public GameObject Gui;
    // Use this for initialization
    private void Awake()
    {
        if(FindObjectOfType<LoadOnClick>() == null) {
            Instantiate(Gui);
        }
        PlaneFinderBehaviour planeFinder = FindObjectOfType<PlaneFinderBehaviour>();
        if(planeFinder != null)
            planeFinder.enabled = true;
    }

    public void disablePlanePlacement() {
        PlaneFinderBehaviour planeFinder = FindObjectOfType<PlaneFinderBehaviour>();
        planeFinder.enabled = false;
    }
}
