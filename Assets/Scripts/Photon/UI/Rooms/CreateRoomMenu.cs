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

        print("PhotonNetwork still connected (!)");

        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 2;
        print("Room Name (1): " + _roomName.text);
        print(options);
        PhotonNetwork.JoinOrCreateRoom(_roomName.text, options, TypedLobby.Default);
        //PhotonNetwork.CreateRoom(_roomName.text, options, TypedLobby.Default);
    }


    public override void OnCreatedRoom()
    {
        //base.OnCreateRoom();
        print("Created room successfully.");
        print("Room Name (2): " + _roomName.text);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        //base.OnCreRoomFailed(returnCode, message);
        print("Room creation failed: " + message);
    }

}


