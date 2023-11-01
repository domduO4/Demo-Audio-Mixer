using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInfos", menuName = "SO/PlayerInfos")]
public class PlayerInfos : ScriptableObject
{
    public string playerName;
    public int playerScore;
    public int playerHealth;
    public int startHealth;

}
