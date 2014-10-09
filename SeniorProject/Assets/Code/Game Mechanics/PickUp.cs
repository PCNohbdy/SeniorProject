using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	void Update()
	{
		if (this.name == "armorIcon")
			transform.Rotate (0, 100.0f * Time.deltaTime, 0);
		else
			transform.Rotate (0, 0, 100.0f * Time.deltaTime);
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (this.name == "HealthPrefab") {
						other.BroadcastMessage ("TakeDamage", -20);
						other.BroadcastMessage ("HealthPickedUp") ;
				}
		Destroy (gameObject);}
	
}
