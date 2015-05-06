using UnityEngine;
using System.Collections;

public class cameraSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.SetResolution ((int)Screen.width/4, (int)Screen.height/4,true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
