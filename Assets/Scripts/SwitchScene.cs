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

    public void OrganMind2()
    {
        PhotonNetwork.LoadLevel(6);
    }

    //public void QuizMaster2()
    //{
    //    PhotonNetwork.LoadLevel(7);
    //}

    public void Intermediate()
    {
        PhotonNetwork.LoadLevel(6);
    }


}
