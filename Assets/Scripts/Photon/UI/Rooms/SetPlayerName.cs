using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using TMPro;

public class SetPlayerName : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _playerName;

    //void Start()
    //{
    //    PhotonNetwork.LocalPlayer.NickName = "User";
    //}


    // Update is called once per frame
    void Update()
    {
        PhotonNetwork.LocalPlayer.NickName = _playerName.text;
    }
}
