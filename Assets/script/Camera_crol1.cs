using UnityEngine;
using System.Collections;

public class Camera_crol1 : MonoBehaviour {
	public GameObject obj;
	public GameObject cam;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void camera_follow()
	{
//		if (Input.GetKeyDown(KeyCode.A )) 
//		{
		Debug.Log ("OK");
		cam.transform.LookAt (obj.transform.position);
			cam.transform.position =new Vector3 ( obj.transform.position.x+20, obj.transform.position.y+5, obj.transform.position.z+3);
			//this.cam.transform.rotation = new Vector3 (30,30,30 );
//		}
//		Vector3 currentposition=this.transform.position;
//		Quaternion currentRotation = this.transform.rotation;
//		Vector3 dir = (obj.transform.position - currentposition).normalized;
//		Quaternion targetRotation = Quaternion.LookRotation (dir);
//		cam.transform.rotation = Quaternion.RotateTowards (currentRotation, targetRotation, 450*Time.deltaTime );
//		cam.transform.position =new Vector3 ( obj.transform.position.x+18, obj.transform.position.y+6, obj.transform.position.z);
//		obj.transform.localScale = new Vector3 (12, 2, 2);
//		Debug.Log ("keu");
	}
}
