using UnityEngine;
using System.Collections;

public class HoverBotAi : MonoBehaviour {
	public enum State {attack, run, dodge, shoot} ;
	public Vector3 PlayerPosition ;
	public Rigidbody bullet ;
	Vector3 NoYRotationVec;
	Vector3 Vec ;
	public State state ;

	// Use this for initialization


	void Start () {
		state = State.attack;
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.FindWithTag ("Player").GetComponent<HealthBar> ().dead)
						return;

		PlayerPosition = GameObject.FindWithTag ("Player").transform.position;
		PlayerPosition.y = 0;
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
		NoYRotationVec = PlayerPosition;
		NoYRotationVec.y = transform.position.y;
		transform.LookAt (NoYRotationVec);
		transform.position = transform.position + transform.forward * Time.deltaTime * 3;

		if (Vector3.Distance (transform.position, PlayerPosition) < 20) {
						
			state = State.shoot;

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
		NoYRotationVec = PlayerPosition;
		NoYRotationVec.y = transform.position.y;
		transform.LookAt (NoYRotationVec);

		Vec = transform.position + transform.forward * 4;

		Vec.y += 4;

		Rigidbody bulletinstance = Instantiate (bullet, Vec, Quaternion.identity)as Rigidbody;


		bulletinstance.AddForce (transform.forward * 2000);



		if (Vector3.Distance (transform.position, PlayerPosition) > 20) 
			state = State.attack;

	}
}
