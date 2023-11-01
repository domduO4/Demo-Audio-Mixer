using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private PlayerInfos infos;
    [SerializeField] private TextMeshProUGUI name;

    private void Start()
    {
        name.text = "Name : " + infos.playerName;
    }
}
