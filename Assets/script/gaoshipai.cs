using UnityEngine;
using System.Collections;

public class gaoshipai : MonoBehaviour {


	public GameObject gaoshipai_text;
	// Use this for initialization
	void Start () {
	
		gaoshipai_text.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag=="gaoshipai") {
			gaoshipai_text.SetActive (true);
		}

	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "gaoshipai") {
			gaoshipai_text.SetActive (false);
		}
	}
}
