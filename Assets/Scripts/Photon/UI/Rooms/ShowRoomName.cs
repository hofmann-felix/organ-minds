using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Realtime;
using Photon.Pun;
using UnityEngine.UI;

public class ShowRoomName : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _roomName;

    bool isSet = false;

    void Update()
    {
        if (!isSet)
        {
            _roomName.text = PhotonNetwork.CurrentRoom.Name;
            isSet = true;
        }
    }

}