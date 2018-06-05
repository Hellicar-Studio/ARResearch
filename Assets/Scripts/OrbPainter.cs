using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbPainter : MonoBehaviour {

    public GameObject orb;
    public GameObject stage;
    public GameObject cam; 
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            GameObject newOrb = Instantiate(orb);
            newOrb.transform.position = cam.transform.position;
            newOrb.transform.SetParent(stage.transform);
        }
	}
}
