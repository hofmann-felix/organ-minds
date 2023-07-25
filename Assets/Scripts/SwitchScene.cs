using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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


}
