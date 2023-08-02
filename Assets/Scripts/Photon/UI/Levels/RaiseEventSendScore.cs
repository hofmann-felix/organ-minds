using ExitGames.Client.Photon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;




public class RaiseEventSendScore : MonoBehaviourPun
{

    private const byte SEND_SCORE_EVENT = 2;

    void Start()
    {
        SendScore();
    }


    private void OnEnable()
    {
        PhotonNetwork.NetworkingClient.EventReceived += OnEvent;
    }

    private void OnDisable()
    {
        PhotonNetwork.NetworkingClient.EventReceived -= OnEvent;
    }


    private void OnEvent(EventData photonEvent)
    {
        byte eventCode = photonEvent.Code;
        if (eventCode == SEND_SCORE_EVENT)
        {
            object[] datas = (object[])photonEvent.CustomData;
            int clientScore = (int)datas[0];
            int totalScore = PlayerPrefs.GetInt("totalScore");
            int currentScore = PlayerPrefs.GetInt("currentPlayerScore");
            print("Total Score before: " + totalScore);
            print("Current Score: " + currentScore);
            int newTotalScore = currentScore + clientScore;
            PlayerPrefs.SetInt("totalScore", newTotalScore);
            int test = PlayerPrefs.GetInt("totalScore");
            print("New Total Score: " + test);
            print("EVENT RECEIVED: Send Score");
        }
    }


    private void SendScore()
    {

        int currentScore = PlayerPrefs.GetInt("currentPlayerScore");

        object[] datas = new object[] { currentScore };



        print("RAISE EVENT: Send Score");
        PhotonNetwork.RaiseEvent(SEND_SCORE_EVENT, datas, RaiseEventOptions.Default, SendOptions.SendReliable);

        
    }
}
