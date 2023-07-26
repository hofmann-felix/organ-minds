using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;
using TMPro;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private TextMeshProUGUI _roomName;



    //[SerializedField]
    //private TextMeshPro _roomName;

    public void OnClick_CreateRoom()
    {

        if (!PhotonNetwork.IsConnected)
            return;

        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 2;
        PhotonNetwork.JoinOrCreateRoom(_roomName.text, options, TypedLobby.Default);
    }


    public override void OnCreatedRoom()
    {
        //base.OnCreateRoom();
        print("Created room successfully.");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        //base.OnCreRoomFailed(returnCode, message);
        print("Room creation failed: " + message);
    }

}


