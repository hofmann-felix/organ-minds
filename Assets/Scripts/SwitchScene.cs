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

    public void QuizScene1(){
        SceneManager.LoadScene("QuizScene1");
    }

     public void QuizScene2(){
        SceneManager.LoadScene("QuizScene2");
    }

     public void QuizScene3(){
        SceneManager.LoadScene("QuizScene3");
    }

     public void QuizScene4(){
        SceneManager.LoadScene("QuizScene4");
    }

     public void QuizScene5(){
        SceneManager.LoadScene("QuizScene5");
    }

     public void QuizScene6(){
        SceneManager.LoadScene("QuizScene6");
    }

    public void OrganMind1()
    {
        PhotonNetwork.LoadLevel("TestScene1");
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
        PhotonNetwork.LoadLevel("IntermediateScene");
    }


}
