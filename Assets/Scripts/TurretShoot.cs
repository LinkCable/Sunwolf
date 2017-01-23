using UnityEngine;
using System.Collections;

public class TurretShoot : MonoBehaviour {

	public Transform target;
	public float range;
	public float turretSpeed;
	private float _lastShotTime = float.MinValue;
	public float fireRate;

public GameObject shot;
	public float shotHeight;
	float sqrDistance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Slerp(transform.rotation, transform.rotation, Time.deltaTime * turretSpeed);

		//Fire at player when in range.
		sqrDistance = (transform.position - target.position).sqrMagnitude;

		if(sqrDistance < range * range && Time.time > _lastShotTime + (3.0f / fireRate))
		{
			_lastShotTime = Time.time;
			fire();
		}    
	}

	void fire()
	{
		Vector3 position = new Vector3(transform.position.x, transform.position.y + shotHeight, transform.position.z);
		GameObject bullet = Instantiate(shot, position, transform.rotation) as GameObject;
		Rigidbody rb = bullet.GetComponent<Rigidbody>();
		rb.velocity = transform.right * 40.0f;
		Destroy (bullet, 10);

		Debug.Log ("shooting");
	}
}
