using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private int speedStat;

    public int SpeedStat { get { return speedStat; } }
}