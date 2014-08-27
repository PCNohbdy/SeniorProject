using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainScreen : MonoBehaviour,
    IHandle<LoadLevelButtonMessage>,
    IHandle<ExitButtonClickMessage>
{

	// Use this for initialization

    void Awake()
    {

    }

	void Start ()
    {
        GameEventAggregator.GameMessenger.Subscribe(this);
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void Handle(LoadLevelButtonMessage message)
    {
        Application.LoadLevelAdditive(message.LevelToLoad);
        Destroy(this.gameObject);
    }

    public void Handle(ExitButtonClickMessage message)
    {
        Destroy(this.gameObject);
        Application.Quit();
    }
}
