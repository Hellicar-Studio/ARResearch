 using UnityEngine;
 using System.Collections;
 
 public class ClickableObject : MonoBehaviour {

    public void checkForTouch() {
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            for (var i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {

                    // Construct a ray from the current touch coordinates
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                    // Create a particle if hit
                    if (Physics.Raycast(ray))
                        onHit();
                    //Debug.Log("Hit!");
                }
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                // Construct a ray from the current touch coordinates
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                // Create a particle if hit
                if (Physics.Raycast(ray))
                    onHit();
            }
        }
    }

    public virtual void onHit() {
        
    }
}