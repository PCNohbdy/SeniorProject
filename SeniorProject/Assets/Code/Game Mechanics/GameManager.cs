using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int PlayerScore ;
	public int AIScore ;
	public float spawnTimer ;
	public bool HealthSpawned ;
	public bool ArmorSpawned ;
	public GameObject HealthPrefab; 
	public Rect PlayerScoreDisplay ;
	public Rect EnemyScoreDisplay;

	public float SpawnRate ;
	private Vector3 HealthPosition ;
	private Vector3 ArmorPosition ;

	// Use this for initialization
	void Start () {
		PlayerScore = 0;
		AIScore = 0;
		HealthSpawned = false; 
		ArmorSpawned = false;
		spawnTimer = 0.0f;
		SpawnRate = 60.0f;
		HealthPosition.Set (107.0f, 2.0f, 142.0f);
		ArmorPosition.Set (107.0f, 4.0f, 55.0f);
		PlayerScoreDisplay.Set (Screen.width * 6 / 7, Screen.height * 7 / 10, Screen.width / 7, Screen.height / 18); 
		                        }

	void OnGUI()
	{

		GUI.Box (PlayerScoreDisplay, "Your Score: " + PlayerScore);

	}
	
	// Update is called once per frame
	void Update () {
	
		if (spawnTimer > SpawnRate && HealthSpawned == false) {

			GameObject go = Instantiate (HealthPrefab, HealthPosition, HealthPrefab.transform.rotation) as GameObject ;
			HealthSpawned = true;
			spawnTimer = 0.0f;
			go.name = "HealthPrefab" ;
						

				} else
						spawnTimer += Time.deltaTime;




		if (PlayerScore >= 10) 
        {
            GameEventAggregator.GameMessenger.Publish(new LoadLevelMessage("WinScene"));
		}
		if (AIScore >= 10)
        {
            GameEventAggregator.GameMessenger.Publish(new LoadLevelMessage("LoseScene"));
		}

	}



	void PlayerScored()
	{
		PlayerScore += 1; 
	}

	void AIScored()
	{
		AIScore += 1;
	}

	void HealthPickedUp()
	{

		HealthSpawned = false;
	}

	
}
