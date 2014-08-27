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
		if (Health < 0)
				Health = 0;
	}
	
	// Update is called once per frame
	void Update () {


	}
}
