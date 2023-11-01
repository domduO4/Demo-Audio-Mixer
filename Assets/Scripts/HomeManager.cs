using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeManager : MonoBehaviour
{

    [SerializeField] private PlayerInfos playerInfos;



    private void Start()
    {
        playerInfos.playerName = "";
        playerInfos.playerHealth = playerInfos.startHealth; //pt problème avec nom du joueur
    }


    public void GetName(string name)
    {
        //Debug.Log("YO " + name);
        playerInfos.playerName = name;
    }
}
