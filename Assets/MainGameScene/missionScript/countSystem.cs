using UnityEngine;

public class countSystem : MonoBehaviour
{
    public MissionManager missionManager;

    public int count = 0;

    public void AddCount(int count)
    {
        count++;
        missionManager.MissionAchieved("1", count);
    }
}
