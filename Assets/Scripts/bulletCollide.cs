using UnityEngine;
using System.Collections;

public class bulletCollide : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col) {

		Debug.Log (col);

		if (col.gameObject.tag == "Destroyable") {
			Destroy (col.gameObject);
		}

	}
}
