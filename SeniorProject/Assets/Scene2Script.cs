using UnityEngine;
using System.Collections;

public class Scene2Script : MonoBehaviour,
        IHandle<LoadLevelButtonMessage>,
        IHandle<LoadInMainScreen>
{

    // Use this for initialization
    void Start()
    {
        GameEventAggregator.GameMessenger.Subscribe(this);
        EventAggregatorManager.Publish(new PlaySoundMessage("LevelMusic", true));
    }

    void OnDestroy()
    {
        EventAggregatorManager.Publish(new StopSoundLoopMessage("LevelMusic"));
        GameEventAggregator.GameMessenger.Unsubscribe(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            EventAggregatorManager.Publish(new LoadInMainScreen());
        }
    }

    public void Handle(LoadLevelButtonMessage message)
    {
        Application.LoadLevelAdditive(message.LevelToLoad);
        Destroy(this.gameObject);
    }

    public void Handle(LoadInMainScreen message)
    {
        Destroy(this.gameObject);
    }
}
