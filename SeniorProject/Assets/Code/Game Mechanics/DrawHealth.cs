using UnityEngine;
using System.Collections;

public class DrawHealth : MonoBehaviour {
	public float Emptybar ;
	public float Healthbar ;
	public Rect lifeBarRect ;
	public Rect lifeBarBackRect ;
	public Rect lifeBarLabel ;
	public Texture2D lifeBarBack ;
	public Texture2D lifeBar ;
	
	// Use this for initialization
	void Start () {

		Emptybar = (float)GetComponent<HealthBar> ().Health;
	
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		 
		Healthbar = (float)GetComponent<HealthBar> ().CurrentHealth;
		lifeBarRect.width = (Screen.width / 5 ) * (Healthbar / Emptybar);
		lifeBarRect.height = Screen.height / 20;
		lifeBarRect.x = 10;
		lifeBarRect.y = (7*Screen.height / 10) ;
		
		lifeBarBackRect.width = Screen.width / 5; 
		lifeBarBackRect.height = Screen.height / 20;
		lifeBarBackRect.x = 10;
		lifeBarBackRect.y = (7*Screen.height / 10) ;


		GUI.DrawTexture (lifeBarBackRect, lifeBarBack);
		GUI.DrawTexture (lifeBarRect, lifeBar);



	}
}
