/// <summary>
/// This Class Is really bad... Can't reuse for any purpose.
/// </summary>



using UnityEngine;
using System.Collections;

public class GenericObject : MonoBehaviour {

	public bool HandlePlayer ;
	private Vector3 RespawnPointOne ;
	private Vector3 RespawnPointTwo ;
	public Rect DeathBox ;
	public Rect YouDeadText ;
	public Rect ClickToContText ;
	public Texture2D dBox ;
	// Use this for initialization
	void Start () {
				
		RespawnPointOne.Set (152.0f, 7.0f, 91.0f);
		RespawnPointTwo.Set (55.0f, 7.0f, 96.0f);
		HandlePlayer = false;
		DeathBox.width = Screen.width;
		DeathBox.height = Screen.height;
		DeathBox.x = 0;
		DeathBox.y = 0;
		YouDeadText.width = Screen.width / 3;
		YouDeadText.height = Screen.width / 2;
		YouDeadText.x = Screen.width / 4;
		YouDeadText.y = Screen.height/5 ;
		ClickToContText.width = Screen.width / 3;
		ClickToContText.height = Screen.height / 4;
		ClickToContText.x = Screen.width / 3;
		ClickToContText.y = Screen.height/2 ;


		                    }
	
	// Update is called once per frame
	void Update () {

		if (HandlePlayer) {

				if(Input.GetKey(KeyCode.Space))
			    {
					HandlePlayer = false ;
					PlayerRespawn () ;
					GameObject.FindWithTag ("Player").GetComponent<HealthBar>().SendMessage("Alive") ;
					
					
				}
				}

	}

	void OnGUI()
	{	                    
		if (HandlePlayer) {

			//GUI.Box (DeathBox,dBox) ;
			GUI.Label (YouDeadText, "YOU HAVE BEEN DISMANTLED...") ;
			GUI.Label (ClickToContText, "click space to respawn") ;

				}
	}

	  
	void OnDeath()
	{
				if (this.tag == "Player") {
						this.GetComponent<GameManager> ().SendMessage ("AIScored");
						HandlePlayer = true ;
						
				} else if (this.tag == "Enemy") {
						GameObject.FindWithTag ("Player").GetComponent<GameManager> ().SendMessage ("PlayerScored");
						AIRespawn ();
						
						
				}

		}

		void AIRespawn()
		{

				Vector3 PlayerPosition = GameObject.FindWithTag ("Player").transform.position;
				
						if (PlayerPosition.x < 104.0f) {
								this.transform.position = RespawnPointOne;
						} else
								this.transform.position = RespawnPointTwo;


				this.GetComponent<HealthBar> ().SendMessage ("Alive");
				
		}

	void PlayerRespawn()
	{	
		Vector3 PlayerPosition = GameObject.FindWithTag ("Enemy").transform.position;

		if (PlayerPosition.x < 104.0f) {
			GameObject.FindWithTag ("Player").transform.position = RespawnPointOne;
		} else
			GameObject.FindWithTag ("Player").transform.position = RespawnPointTwo;
	}


}
