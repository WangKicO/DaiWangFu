using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	void Update(){
		if (Input.GetKey(KeyCode.Escape)) {
		
			#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying=false;
			#else
			Application.Quit();
			#endif
		}
	}

	public void DaiWangFu_Button(){
	
		Application.LoadLevel ("DaiWangFu_Ready");
	}

	public void Quit(){

		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying=false;
		#else
		Application.Quit();
		#endif
	}

	public void Guide(){

		Application.LoadLevel ("s01");
	}

	public void Panorama(){

		Application.LoadLevel ("s02");
	}

	public void Back(){

		Application.LoadLevel ("DaiWangFu_Start");
	}
}
