using UnityEngine;
using UnityEditor;


[CustomPropertyDrawer(typeof(SoundsClipClass))]
public class SoundsClipClassDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty prop, GUIContent label)
    {
        EditorGUIUtility.LookLikeControls();
        position.x -= 10;

        position.width *= 0.70f;

        SerializedProperty SoundNameProp = prop.FindPropertyRelative("SoundName");
        SerializedProperty SoundFileProp = prop.FindPropertyRelative("SoundFile");
        SerializedProperty SoundInstances = prop.FindPropertyRelative("Instance");
        EditorGUI.BeginChangeCheck();
        string String = EditorGUI.TextField(position, label.text, SoundNameProp.stringValue);

        position.x += position.width;
        position.width *= 0.35f;

        AudioClip AudioClip = EditorGUI.ObjectField(position, "", SoundFileProp.objectReferenceValue, typeof(AudioClip),false) as AudioClip;

        position.x += position.width - 10;
        position.width *= .80f;
        int temp = EditorGUI.IntField(position, label.text, SoundInstances.intValue);

        if (EditorGUI.EndChangeCheck())
        {
            SoundFileProp.objectReferenceValue = AudioClip;
            if (String == "")
                String = AudioClip.name;
            SoundNameProp.stringValue = String;
            SoundInstances.intValue = temp;

        }
    }
}
