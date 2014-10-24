using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour,
    IHandle<LoadInMainScreen>
{

	// Use this for initialization
    SoundManager SM;
    public List<SoundsClipClass> SoundsToLoad;
    public MainScreen MainScreenManager;
    private MainScreen m_MainScreen;
    void Awake()
    {
        EventAggregatorManager.AddEventAggregator(GameEventAggregator.GameMessenger);
    }

    void Start()
    {
        GameEventAggregator.GameMessenger.Subscribe(this);
        LoadInSounds();
        GetMainScreen();
    }

    void OnDestroy()
    {
        GameEventAggregator.GameMessenger.Unsubscribe(this);
    }

    void LoadInSounds()
    {
        SM = gameObject.GetComponent<SoundManager>() as SoundManager;

        for (int i = 0; i < SoundsToLoad.Count; ++i)
            SM.LoadSound(SoundsToLoad[i].SoundName, SoundsToLoad[i].SoundFile, SoundsToLoad[i].Instance);
    }

    // Update is called once per frame
    void Update()
    {
        GameEventAggregator.GameMessenger.Update();
    }

    MainScreen GetMainScreen()
    {
        if (m_MainScreen == null)
        {
            m_MainScreen = MainScreen.Instantiate(MainScreenManager) as MainScreen;
            m_MainScreen.gameObject.transform.parent = this.gameObject.transform;
        }
        return m_MainScreen;
    }

    public void Handle(LoadInMainScreen message)
    {
        GetMainScreen();
    }
}
