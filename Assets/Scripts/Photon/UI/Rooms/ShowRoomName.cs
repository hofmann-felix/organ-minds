using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Realtime;
using Photon.Pun;

public class ShowRoomName : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _roomName;

    void Start()
    {
        _roomName.text = PhotonNetwork.CurrentRoom.Name;
    }

}
