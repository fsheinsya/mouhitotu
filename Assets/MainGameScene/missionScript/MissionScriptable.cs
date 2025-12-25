using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Mission", menuName = "Scriptable Objects/Mission")]
public class MissionScriptable : ScriptableObject
{
    public string id;
    public int count = 10;
    public string description;
    public bool isCleared;
    public bool isAcquired;
    public Image clearedImage;
    public MissionPanel missionPanel;
}
