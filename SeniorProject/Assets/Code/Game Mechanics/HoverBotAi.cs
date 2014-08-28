using UnityEngine;
using System.Collections;

public class HoverBotAi : MonoBehaviour {
	enum State {attack, run, dodge, shoot} ;
	public Transform playerPosition ;
	public Rigidbody bullet ;
	Vector3 NoYRotationVec;
	Vector3 Vec ;
	State state ;
	float previousTime ;
	// Use this for initialization


	void Start () {
		state = State.attack;
	}
	
	// Update is called once per frame
	void Update () {


		if (state == State.attack) {
						Attack ();
		
				} else if (state == State.run) {



				} else if (state == State.dodge) {


				} else if (state == State.shoot) {
			AiShoot() ;
				}
	}

	void Attack()
	{
		NoYRotationVec = playerPosition.position;
		NoYRotationVec.y = transform.position.y;
		transform.LookAt (NoYRotationVec);
		transform.position = transform.position + transform.forward * Time.deltaTime * 3;

		if (Vector3.Distance (transform.position, playerPosition.position) < 20) {
						
			state = State.shoot;
			previousTime = Time.time ;
				}
	}


	void dodge()
	{

	}

	void run()
	{

	}

	void AiShoot()
	{
		NoYRotationVec = playerPosition.position;
		NoYRotationVec.y = transform.position.y;
		transform.LookAt (NoYRotationVec);

		Vec = transform.position + transform.forward * 4;

		Vec.y -= 2;

		Rigidbody bulletinstance = Instantiate (bullet, Vec, Quaternion.identity)as Rigidbody;


		bulletinstance.AddForce (transform.forward * 2000);



		if (Vector3.Distance (transform.position, playerPosition.position) > 20) 
			state = State.attack;

	}
}
