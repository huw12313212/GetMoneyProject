using UnityEngine;
using System.Collections;

public class LoadFromHttp : MonoBehaviour {

	public string url;
	IEnumerator Start() {
		WWW www = new WWW(url);
		yield return www;

		GetComponent<Renderer> ().material.mainTexture = www.texture;
	}

}
