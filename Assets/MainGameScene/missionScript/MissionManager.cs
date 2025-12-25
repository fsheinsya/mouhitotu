using UnityEngine;
using UnityEngine.UI;

public class MissionManager : MonoBehaviour
{
    [SerializeField] private MissionDataScriptable masterData;
    [SerializeField] private MissionPanel missionPanelPrefab;
    private ScrollRect _scrollRect;

    public MissionData missionData;

    //後に
    private const string iscleared = "iscleared";

    private void Awake()
    {
        _scrollRect = GetComponent<ScrollRect>();
    }

    public void Start()
    {
        missionData = new MissionData(masterData.missions);

        foreach (var mission in masterData.missions)
        {
            var missionPanel = Instantiate(missionPanelPrefab);
            mission.missionPanel = missionPanel;
            missionPanel.missionDescription.text = mission.description;


            missionPanel.clearedButton.interactable = mission.isCleared && !mission.isAcquired;

            //達成、未達成、UIの表示済みの３通りのパターンの処理を記述

        }
    }

    public void MissionAchieved(string id, int count)
    {
        foreach (var mission in missionData.missions)
        {
            if (mission.id != id) continue;
            if(mission.isCleared) continue;
            if (mission.count > count) continue;
            mission.isCleared = true;
        }
    }
 }
