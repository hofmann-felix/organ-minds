using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOrganCount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("currentOrganIndex", 0);
        PlayerPrefs.SetInt("currentPlayerScore", 0);
        PlayerPrefs.SetInt("totalScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
