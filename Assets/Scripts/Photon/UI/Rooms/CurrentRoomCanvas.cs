using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentRoomCanvas : MonoBehaviour
{
    private RoomsCanvases _roomsCanvases;

    public void FirstInitialize(RoomsCanvases canvases)
    {
        _roomsCanvases = canvases;
    }

    public void Show()
    {
        gameObject.SetActive(true);
        print("Should set current gameObject Visible");
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
