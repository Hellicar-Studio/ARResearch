 using UnityEngine;
 using System.Collections;
 
 public class RedFader : ClickableObject {
    public Color col;
    public Material material;

    void Setup() {
        if (material == null)
            material = GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        checkForTouch();
        col = Color.Lerp(col, Color.blue, 0.1f);
        material.SetColor("_Color", col);

    }

    public override void onHit() {
        col = Color.red;
        Debug.Log("Hit!");
    }
}