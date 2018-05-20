using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DistanceController : MonoBehaviour, ICustomMessageTarget {

	public GameObject sphere;
	private Text targetText;
	double limit = 4.3;
	bool stop = false;
	
	public void Message1() {
        stop = true;
    }

	// Use this for initialization
	void Start () {		
		this.targetText = this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!stop && sphere.transform.position.x < limit) {
			this.targetText.text = string.Format("{0:0.0}", -sphere.transform.position.x + limit) + " m";
		}
	}
}
