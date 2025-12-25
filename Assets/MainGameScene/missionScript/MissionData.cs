using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MissionData : MonoBehaviour
{
    public List<Mission> missions;
    
    public MissionData(MissionScriptable[] missionData)
    {
        missions = new List<Mission>();
        foreach(var mission in missionData)
        {
            missions.Add(new Mission(mission));
        }
    }

    [Serializable]
    public class Mission
    {
        public MissionPanel missionPanel;
        public string id;
        public int count;
        public string description;
        public bool isCleared;
        public bool isAcquired;

        public Mission(MissionScriptable mission)
        {
            id = mission.id;
            count = mission.count;
            description = mission.description;
            isCleared = false;
        }
    }
}
