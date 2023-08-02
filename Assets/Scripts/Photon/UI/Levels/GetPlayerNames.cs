using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Realtime;
using Photon.Pun;

public class GetPlayerNames : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _player1;

    [SerializeField]
    private TextMeshProUGUI _player2;
    //public Player Player { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
        //SetPlayerInfo();
        //_player1.text = player.NickName;
        //Player playerList[] = PhotonNetwork.PlayerListOthers;
        //player2 = playerList[0];
        //_player2.text = player2;
        _player1.text = PhotonNetwork.LocalPlayer.NickName;
        _player2.text = PhotonNetwork.LocalPlayer.NickName;

        //int score = 

    }



    //public void SetPlayerInfo(Player player)
    //{
    //Player = player;
    //_player1.text = PhotonNetwork.player.NickName;
    //_player2.text = PhotonNetwork.player.NickName;

    //    
    //    _player1.text = player.NickName;
    //    _player2.text = player.NickName;
    //}

}
