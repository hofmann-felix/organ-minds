using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Realtime;
using Photon.Pun;

public class SwitchScene : MonoBehaviour
{
    public void RoomsScene()
    {
        SceneManager.LoadScene("CreateRooms");
    }

    public void StartGameSzene()
    {
        SceneManager.LoadScene("StartGame");
    }

    public void BodyTracking()
    {
        SceneManager.LoadScene("HumanBodyTracking3D");
    }

    public void OrganMind1()
    {
        PhotonNetwork.LoadLevel(4);
    }

    public void QuizMaster1()
    {
        PhotonNetwork.LoadLevel(5);
    }


}
