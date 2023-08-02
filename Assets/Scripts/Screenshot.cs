using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    public void OnMouseDown()
    {
        ScreenCapture.CaptureScreenshot("Urkunde.png");
    }
}
