using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

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
		if (other.tag == "Player") {
						other.BroadcastMessage ("TakeDamage", 1);
				}
		Destroy (gameObject);
	}
}
