using UnityEngine;
using System.Collections;

public class AutoDestroyParticle : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		if(gameObject.particleSystem)
		{
			GameObject.Destroy(gameObject, gameObject.particleSystem.duration + gameObject.particleSystem.startLifetime);
		}
	}
}