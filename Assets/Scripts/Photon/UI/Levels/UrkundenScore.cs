using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UrkundenScore : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _score;

    // Start is called before the first frame update
    void Start()
    {
        int finalScore = PlayerPrefs.GetInt("totalScore");
        _score.text = "SCORE: " + finalScore;
        //int score = 

    }
}
