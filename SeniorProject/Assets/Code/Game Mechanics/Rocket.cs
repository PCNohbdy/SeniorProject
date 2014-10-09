using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {
	public ParticleSystem sys ;
	// Use this for initialization
	void Update () {
		if (transform.position.y < 0)
			Destroy (gameObject);
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy") {
			other.BroadcastMessage ("TakeDamage", 5);
		}
		Instantiate (sys,transform.position, Quaternion.identity);
		Destroy (gameObject);
	}
}
