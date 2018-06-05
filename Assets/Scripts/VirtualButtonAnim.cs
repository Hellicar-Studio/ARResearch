using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonAnim : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vbBtnObj;
    public Animator cubeAni;

	// Use this for initialization
	void Start () {
        vbBtnObj = GameObject.Find("SpinButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        cubeAni.Play("Cube_Animation");
        Debug.Log("BTN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour virtualButton) {
        cubeAni.Play("none");
        Debug.Log("BTN Released");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
