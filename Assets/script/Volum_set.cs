using UnityEngine;
using System.Collections;

public class Volum_set : MonoBehaviour
{
	public UISlider slider;
	public UISprite sprite;
	public GameObject volum;
	public AudioSource audio;

	void Start()
	{
		volum.SetActive(false);
	}
	void Update()
	{
		audio.volume = slider.value;
		if (slider.value == 0)
		{
			sprite.spriteName = "jingyin";
		}
		else
		{
			sprite.spriteName = "yinliang";
		}
	}

	public void setVolum()
	{
		if (volum.active == false)
		{
			volum.SetActive(true);

		}
		else
		{
			volum.SetActive(false);

		}
	}
}
