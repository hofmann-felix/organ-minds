using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class InfoSign : MonoBehaviour
{
    void Start()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            gameObject.SetActive(false);
        }
    }
}
