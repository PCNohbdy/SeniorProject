using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainScreen : MonoBehaviour
{

	// Use this for initialization
    SoundManager SM;
    public List<SoundsClipClass> SoundsToLoad;

	void Start ()
    {
        LoadInSounds();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void LoadInSounds()
    {
        SM = gameObject.GetComponent<SoundManager>() as SoundManager;

        for (int i = 0; i < SoundsToLoad.Count; ++i)
            SM.LoadSound(SoundsToLoad[i].SoundName, SoundsToLoad[i].SoundFile, SoundsToLoad[i].Instance);


    }

}
