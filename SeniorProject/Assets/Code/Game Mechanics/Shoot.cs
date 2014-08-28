using UnityEngine;
using System.Collections;



public class Shoot : MonoBehaviour {
	public Rigidbody prefabBullet;
	public float bulletSpeed;
	public Vector3 vec;
	public AudioSource m ;
	public AudioClip audio ;
	// Use this for initialization
	void Start () {

		bulletSpeed = 1000;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButtonDown ("Fire1")) {
			m.PlayOneShot(audio) ;
			vec = transform.position + transform.forward * 2 ;
			vec.y = 4 ;

			Rigidbody bulletInstance = Instantiate(prefabBullet, vec , transform.rotation) as Rigidbody;

			bulletInstance.AddForce(transform.forward * bulletSpeed);
	
		}
	}
}


