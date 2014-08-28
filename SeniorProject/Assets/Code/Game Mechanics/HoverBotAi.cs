using UnityEngine;
using System.Collections;

public class HoverBotAi : MonoBehaviour {
	enum State {attack, run, dodge} ;
	public Transform playerPosition ;
	Vector3 NoYRotationVec;
	State state ;
	// Use this for initialization


	void Start () {
		state = State.run;
	}
	
	// Update is called once per frame
	void Update () {


		if (state == State.attack) {
			Attack () ;
		
				}
	}

	void Attack()
	{
		NoYRotationVec = playerPosition.position;
		NoYRotationVec.y = transform.position.y;
		transform.LookAt (NoYRotationVec);
		transform.position = transform.position + transform.forward * Time.deltaTime * 3;
	}


	void dodge()
	{

	}

	void run()
	{

	}
}
