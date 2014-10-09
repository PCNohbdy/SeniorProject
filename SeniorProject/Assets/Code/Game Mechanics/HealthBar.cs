using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {
	public int Health  ;
	public int CurrentHealth ;
	public bool dead ;

	// Use this for initialization
	void Start () {
		Health = 100;
		CurrentHealth = 100;
		dead = false;
	}

	void TakeDamage(int damage)
	{
		CurrentHealth -= damage; 
		if (CurrentHealth < 0 ) {

			CurrentHealth = 0;
			if(dead == false)
			{
				dead = true ;
				gameObject.SendMessage ("OnDeath") ;
			}
				
		}
	}
	
	// Update is called once per frame
	void Update () {


	}

	void Alive()
	{
		CurrentHealth = 100;
		dead = false;

	}
}
