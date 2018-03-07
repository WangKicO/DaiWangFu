using UnityEngine;
using System.Collections;

public class camera_follow : MonoBehaviour {
	public float Speed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {

			this.transform.position += Vector3.left * Speed*Time.deltaTime;

		}
		if (Input.GetKey (KeyCode.RightArrow)) {

			this.transform.position += Speed*Time.deltaTime*Vector3.right;

		}
		if (Input.GetKey (KeyCode.UpArrow)) {

			this.transform.position += Vector3.forward*Speed*Time.deltaTime;

		}
		if (Input.GetKey (KeyCode.DownArrow)) {

			this.transform.position += Vector3.forward *-Speed*Time.deltaTime;

		}
		if (Input.GetKey (KeyCode.Space )) {

			this.transform.position += Vector3.up *Speed*Time.deltaTime;

		}
	}
  

}
