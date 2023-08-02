using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int currentScore = PlayerPrefs.GetInt("currentPlayerScore");
        PlayerPrefs.SetInt("currentPlayerScore", currentScore + 2);
    }

}
