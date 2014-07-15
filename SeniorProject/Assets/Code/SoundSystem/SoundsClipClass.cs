using UnityEngine;

[System.Serializable]
public class SoundsClipClass : System.Object
{
    public string SoundName;
    public AudioClip SoundFile;
    public int Instance = 1;

    public SoundsClipClass()
    {
        Instance = 1;
    }

    public SoundsClipClass(AudioClip audio)
    {
        Debug.Log(audio.name);
        if (audio != null)
        {
            SoundFile = audio;
            SoundName = SoundFile.name;
            Instance = 1;
        }
    }

}
