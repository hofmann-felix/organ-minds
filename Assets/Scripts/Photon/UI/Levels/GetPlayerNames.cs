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

    // Start is called before the first frame update
    void Start()
    {

        //SetPlayerInfo();
        _player1.text = PhotonNetwork.LocalPlayer.NickName;
        //_player1.text = player.NickName;
        foreach (Player p in PhotonNetwork.PlayerListOthers)
        {
            _player2.text = p.NickName;
        }
        

    }


}
