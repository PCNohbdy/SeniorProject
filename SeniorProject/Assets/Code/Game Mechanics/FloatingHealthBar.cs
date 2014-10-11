using UnityEngine;
using System.Collections;

public class FloatingHealthBar : MonoBehaviour {

	public Transform parent ;
	public Vector3   OffSet ;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = parent.position + OffSet;
		this.transform.LookAt (GameObject.Find ("Main Camera").transform.position);
		Vector3 scale = this.transform.localScale;
		scale.x = ((float)GameObject.FindWithTag ("Enemy").GetComponent<HealthBar> ().CurrentHealth / 100.0f) * 4.0f;
		this.transform.localScale = scale;
	}



}
