using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {
	public ParticleSystem sys ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 0)
			Destroy (gameObject);
	}

	void OnTriggerEnter(Collider other)
	{
		Instantiate (sys, transform.position, Quaternion.identity);
		if (other.tag == "Player") {
			other.BroadcastMessage ("TakeDamage", 10);
		}

		Destroy (gameObject);
	}
}
