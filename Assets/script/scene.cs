using UnityEngine;
using System.Collections;

public class scene : MonoBehaviour {
	public GameObject button;
	public GameObject button1;
	public GameObject panel;
	public GameObject pane2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Click1()
	{
		button.transform.position = new Vector3 (-0.5f, -0.1f, 0);
		button1.transform.position = new Vector3 (-0.5f, -0.7f, 0);
		panel.SetActive (true);	
		pane2.SetActive (false);	
	}
	public void Click2()
	{
		button.transform.position = new Vector3 (-0.5f, -0.1f, 0);
		button1.transform.position = new Vector3 (-0.5f, -0.7f, 0);
		panel.SetActive (false);	
		pane2.SetActive (true);
	}
}
