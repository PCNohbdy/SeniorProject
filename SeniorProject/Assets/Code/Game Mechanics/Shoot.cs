using UnityEngine;
using System.Collections;



public class Shoot : MonoBehaviour {
	public Rigidbody prefabBullet;
	public float bulletSpeed;
	public Vector3 vec;
    public string m_AudioSound;
	// Use this for initialization
	void Start () {

		bulletSpeed = 1000;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (GetComponent<HealthBar> ().dead)
						return;

		if (Input.GetButtonDown ("Fire1")) {
            EventAggregatorManager.Publish(new PlaySoundMessage(m_AudioSound, false));

			vec = transform.position + transform.forward * 5;
		
			vec.y = 4.0f;
			Rigidbody bulletInstance = Instantiate(prefabBullet, vec , prefabBullet.transform.rotation) as Rigidbody;

			bulletInstance.AddForce(transform.forward * bulletSpeed);
	
		}
	}
}


