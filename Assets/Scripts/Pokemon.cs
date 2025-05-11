using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public string Name;
    public int HealthStat;
    public int AttackStat;
    public int DefenceStat;
    public int SpecialAttackStat;
    public int SpecialDefenceStat;
    public int SpeedStat;

    public int EvasionStat = 100;
    public int AccuracyStat = 100;
    public int Level;
    public int NoOfStages;
    public Dictionary<string, int> Nature;
}
