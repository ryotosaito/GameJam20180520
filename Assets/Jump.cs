using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Jump : MonoBehaviour {

	bool pushed = false;
	double limit = 4.3;
	public GameObject text;
	
	void OnCollisionEnter(Collision col) {
		if (transform.position.x < limit) {
			ExecuteEvents.Execute<ICustomMessageTarget>(text, null, (x,y)=>x.Message1());
			Debug.Log("collision");
		}
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {
			Debug.Log("Enter");
			GetComponent<Rigidbody>().useGravity = true;
		}
		// Debug.Log(transform.position.x + 0);
		if (!pushed
			&& Input.GetKeyDown(KeyCode.Space)
			&& transform.position.x >= limit) {
			Debug.Log("pushed");
			GetComponent<Rigidbody>().AddForce(
				new Vector3(0, 5, 0),
				ForceMode.Impulse
			);
			pushed = true;
		}
	}
}
