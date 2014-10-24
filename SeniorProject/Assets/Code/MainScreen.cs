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
        EventAggregatorManager.Publish(new PlaySoundMessage("MainMenuMusic", true));
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void Handle(LoadLevelButtonMessage message)
    {
        Application.LoadLevelAdditive(message.LevelToLoad);
        EventAggregatorManager.Publish(new StopSoundLoopMessage("MainMenuMusic"));
        EventAggregatorManager.Publish(new PlaySoundMessage("LevelMusic", true));
        Destroy(this.gameObject);
    }

    public void Handle(ExitButtonClickMessage message)
    {
        EventAggregatorManager.Publish(new StopSoundLoopMessage("MainMenuMusic"));
        Destroy(this.gameObject);
        Application.Quit();
    }
}
