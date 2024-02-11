using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mission", menuName = "Mission System/Mission Object", order = 1)]
public class MissionSystem : ScriptableObject
{
    public string missionName = null;
    public string description = null;
    public List<string> subMissions = null;
    public bool isCompleted = false;
}
