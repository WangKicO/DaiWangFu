using UnityEngine;
using System.Collections;

public class music_ctro : MonoBehaviour {
	public GameObject obj;
	public GameObject buttonnotplay;

	public GameObject buttonplay;

	// Use this for initialization
	void Start () {
		//obj.GetComponent<AudioSource> ().volume = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Cplaymusic()
	{
		buttonplay.SetActive (true);
		buttonnotplay.SetActive (false );
		obj.GetComponent<AudioSource> ().volume = 1f;
		obj.GetComponent<AudioSource> ().Play () ;
	}
	public void Nplaymusic()
	{
		buttonplay.SetActive (false );
		buttonnotplay.SetActive (true);
		obj.GetComponent<AudioSource> ().volume=0f;
	}
}
