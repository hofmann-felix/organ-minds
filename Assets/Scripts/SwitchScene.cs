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

    public void TestScene1()
    {
        PhotonNetwork.LoadLevel("TestScene1");
    }

    public void TestScene2()
    {
        PhotonNetwork.LoadLevel("TestScene2");
    }

    public void TestScene3()
    {
        PhotonNetwork.LoadLevel("TestScene3");
    }

    public void TestScene4()
    {
        PhotonNetwork.LoadLevel("TestScene4");
    }

    public void TestScene5()
    {
        PhotonNetwork.LoadLevel("TestScene5");
    }

    public void TestScene6()
    {
        PhotonNetwork.LoadLevel("TestScene6");
    }


    //public void QuizMaster2()
    //{
    //    PhotonNetwork.LoadLevel(7);
    //}

    public void Intermediate1()
    {
        PhotonNetwork.LoadLevel("IntermediateScene1");
    }

    public void Intermediate2()
    {
        PhotonNetwork.LoadLevel("IntermediateScene2");
    }

    public void Intermediate3()
    {
        PhotonNetwork.LoadLevel("IntermediateScene3");
    }

    public void Intermediate4()
    {
        PhotonNetwork.LoadLevel("IntermediateScene4");
    }

    public void Intermediate5()
    {
        PhotonNetwork.LoadLevel("IntermediateScene5");
    }

    public void Intermediate6()
    {
        PhotonNetwork.LoadLevel("IntermediateScene6");
    }

    public void OrganDetectorMaster()
    {
        PhotonNetwork.LoadLevel("HumanBodyTracking3D Quiz Master");
    }

    public void OrganDetectorClient()
    {
        PhotonNetwork.LoadLevel("HumanBodyTracking3D Organ Detector");
    }

    public void Urkunde()
    {
        PhotonNetwork.LoadLevel("Urkunde");
    }


}
