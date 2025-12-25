using UnityEngine;

[CreateAssetMenu(fileName = "MissionData", menuName = "Scriptable Objects/MissionData")]
public class MissionDataScriptable : ScriptableObject
{
    public MissionScriptable[] missions;
}
