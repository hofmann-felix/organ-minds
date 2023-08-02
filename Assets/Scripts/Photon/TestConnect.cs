using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class TestConnect : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    private void Start()
    {
        print("Connecting to server..");
        PhotonNetwork.AutomaticallySyncScene = true; // eventuell auskommentieren für asynchronität
        PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
        //PhotonNetwork.GameVersion = "0.0.1";
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        print("Connected to server!");
        print("Nickname: " + PhotonNetwork.LocalPlayer.NickName);
        //Debug.Log("OnConnectedToMaster() was called by PUN");

        //PhotonNetwork.LocalPlayer.NickName = "Test";

        if (!PhotonNetwork.InLobby)
            // Join Lobby
            PhotonNetwork.JoinLobby();

        int currentScore = PlayerPrefs.GetInt("currentPlayerScore");
        print("Current SCORE: " + currentScore);
    }


    public override void OnDisconnected(DisconnectCause cause)
    {
        print("Disconnected from server due to following reason: " + cause.ToString());
    }

}