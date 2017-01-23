using UnityEngine;
using System.Collections;

public class Ring : MonoBehaviour {

	public float speed = 20f;
	public AudioClip collisionSound;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, speed * Time.deltaTime);
	}

	void OnCollisionEnter (Collision col) {
		GameObject.Destroy ( gameObject ) ;
		source.PlayOneShot (collisionSound, 1.0f);
	}
}
