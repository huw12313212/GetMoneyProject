using UnityEngine;
using System.Collections;
using TouchScript.Gestures;

public class BaseMale : MonoBehaviour {

	public GameObject Male;
	public PanGesture pan;
	public GameObject X;
	public GameObject Y;
	bool waitOneFrame = false;

	// Use this for initialization
	void Start () {

		pan.PanStarted += (object sender, System.EventArgs e) => 
		{
			waitOneFrame = true;
		};

		pan.Panned += (object sender, System.EventArgs e) => 
		{

			if(waitOneFrame)
			{
				waitOneFrame = false;
				return;
			}

			Vector3 v3 = pan.WorldDeltaPosition;

			v3.x *= 1000;
			v3.y *= 1000;
			v3.z *= 1000;



			X.transform.localRotation = Quaternion.Euler(0,-v3.x,0);
			Y.transform.localRotation = Quaternion.Euler(-v3.y,0,0);

			Male.transform.parent =null;
			X.transform.localRotation = Quaternion.Euler(0,0,0);
			Y.transform.localRotation = Quaternion.Euler(0,0,0);
			Male.transform.parent = Y.transform;


			Debug.Log("Camera?"+v3);

		};


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
