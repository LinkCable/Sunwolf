using UnityEngine;
using System.Collections;

public class enemyShoot : MonoBehaviour {

	public Transform SpawnPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col) {

		if (col.gameObject.tag == "Player") {
			col.transform.position = SpawnPoint.position;
			col.transform.rotation = Quaternion.Euler(new Vector3(0,270,0)); 
		}

	}
}
