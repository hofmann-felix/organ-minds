using ExitGames.Client.Photon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;




public class RaiseEventContinue : MonoBehaviourPun//Pun //, IOnEventCallback  //MonoBehaviourPunCallbacks
{
    //private SpriteRenderer _spriteRenderer;

    private const byte VISIBILITY_CHANGE_EVENT_CONTINUE = 2;


    //private void Awake()
    //{
    //    _spriteRenderer = GetComponent<SpriteRenderer>();
    //}
    //private int count = 0;

    void Start()
    {
        //if (base.photonView.IsMine && Input.GetKeyDown(KeyCode.Space))
        //{
        //    print("Space key was pressed");
        ChangeVisibility();
        //}
    }
    // Update is called once per frame
    //void Update()
    //{
        // IsMine belongs to Master Client
    //    if (base.photonView.IsMine && Input.GetKeyDown(KeyCode.Space))
    //    {
    //        print("Space key was pressed");
    //        ChangeVisibility();
    //    }
            
    //}

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
        if (eventCode == VISIBILITY_CHANGE_EVENT_CONTINUE)
        {
            print("EVENT RECEIVED: Change Visibility");
            gameObject.SetActive(true);
            PhotonNetwork.RaiseEvent(VISIBILITY_CHANGE_EVENT_CONTINUE, null, RaiseEventOptions.Default, SendOptions.SendReliable);
        }
    }


    private void ChangeVisibility()
    {
        //gameObject.SetActive(false);
        //object[] datas = new object[] { };
        

        //print("COUNT: " + count);

        
        PhotonNetwork.RaiseEvent(VISIBILITY_CHANGE_EVENT_CONTINUE, null, RaiseEventOptions.Default, SendOptions.SendReliable);

        //if (count > 0)
        //{
        //    gameObject.SetActive(false);
        //}

        //PhotonNetwork.RaiseEvent(MoveUnitsToTargetPositionEventCode, content, raiseEventOptions, SendOptions.SendReliable);
        //count += 1;
    }
}
