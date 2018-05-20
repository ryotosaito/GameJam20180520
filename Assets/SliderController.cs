using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour {

  	Slider _slider;
	public GameObject sphere;
	public Image image;
	bool stopped = false;
	bool changed = false;
	float start;
	float limit = 4.3f;

	// Use this for initialization
	void Start () {
		start = sphere.transform.position.x;
    	_slider = GameObject.Find("Slider").GetComponent<Slider>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!stopped) {
    		_slider.value = (sphere.transform.position.x - start) * (0.8f / (limit - start));
			if (Input.GetKeyDown(KeyCode.Space)) {
				stopped = true;
			}
		}
		if (sphere.transform.position.x < limit && !changed && !stopped) {
			Debug.Log("change");
			image.color = Color.red;
			changed = true;
		}
	}
}
