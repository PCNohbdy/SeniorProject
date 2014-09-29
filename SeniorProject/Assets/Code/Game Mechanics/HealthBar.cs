using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {
	public int Health  = 100 ;
	public int CurrentHealth = 100 ;

	// Use this for initialization
	void Start () {
	
	}

	void TakeDamage(int damage)
	{
		CurrentHealth -= damage;
		if (CurrentHealth < 0) {
						CurrentHealth = 0;
						Destroy (gameObject);
				}
	}
	
	// Update is called once per frame
	void Update () {


	}
}
