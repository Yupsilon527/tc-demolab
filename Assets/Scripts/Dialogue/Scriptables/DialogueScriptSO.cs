using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueScriptSO", menuName = "Dialogue/DialogueScriptSO")]
public class DialogueScriptSO : ScriptableObject
{
    public enum CharacterEmotion
    {
        none = -1,
        normal = 0,
        angry = 1
    }
    public enum AudioPlayType
    {
        never = 0,
        before = 1,
        after = 2
    }
    public DialogueLine[] Dialogue;
    [System.Serializable]
    public class DialogueLine
    {
        public string name;
        [Header("Character")]
        public DialogueCharacterSO Character;
        public CharacterEmotion Emotion;

        [Header("What Is Said")]
        public string Quote;
        public float Wait;

        [Header("Effects")]
        public AudioPlayType PlayType = AudioPlayType.never;
        public AudioClip AudioClip;
        public float DialogueShake;
    }
    public ChoiceSO EndChoice;
}
