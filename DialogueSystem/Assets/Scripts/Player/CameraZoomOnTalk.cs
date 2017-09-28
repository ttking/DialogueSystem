using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomOnTalk : MonoBehaviour {

    private float normal = 8f;
    private float zoom = 3.0f;
    private float smooth = 5f;

    private bool zoomBool;

	
	// Update is called once per frame
	void Update () {
        if (zoomBool)
        {
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, zoom, Time.deltaTime * smooth);
        }
        else
        {
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, normal, Time.deltaTime * smooth);
        }
    }
    // zooming when talking is triggered
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Npc")
        {
            zoomBool = true;
        }
    }

    // going back to normall when talking is triggered
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Npc")
        {
            zoomBool = false;
        }
    }
}
