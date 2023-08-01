using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerCanvases : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = false;
        if (PhotonNetwork.IsMasterClient)
        {
            print("You are the Master client   !!!!!!!!!!!!!!!!!!");
            gameObject.SetActive(false);
        }
        if (!PhotonNetwork.IsMasterClient)
        {
            print("You are the NOT Master client   !!!!!!!!!!!!!!!!!!");
        }
    }
}
