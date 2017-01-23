using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	float speed = 5.0f;
	public GameObject prefab;
	public Transform SpawnPoint;

	// Use this for initialization
	void Start () {
		prefab = Resources.Load ("bullet") as GameObject;
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1")) {
			GameObject shot = Instantiate (prefab) as GameObject;
			shot.transform.position = transform.position + transform.forward;
			shot.transform.Translate (0, 0, -0.3f);
			shot.transform.rotation = transform.rotation;
			shot.transform.Rotate (90, 0, 0);
			Rigidbody rb = shot.GetComponent<Rigidbody>();
			rb.velocity = transform.forward * 200.0f;
			Destroy (shot, 3);
		}
			
		transform.position += transform.forward * Time.deltaTime * speed;

		speed += transform.forward.y * Time.deltaTime * 2.0f;

		if (speed > 30.0f) {
			speed = 30.0f;
		}

		transform.Rotate (Input.GetAxis ("Vertical"), 0.0f, -1.0f * Input.GetAxis ("Horizontal"));
	}
		
	void OnCollisionEnter (Collision col) {
	
		if (col.gameObject.name == "Plane" || col.gameObject.tag == "Box") {
			transform.position = SpawnPoint.position;
			transform.rotation = Quaternion.Euler(new Vector3(0,270,0)); 
		}
			
	}
		
}
