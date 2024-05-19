using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    [SerializeField] TextMeshProUGUI textScore;

    private void Update()
    {
        textScore.text = "Score "+ score.ToString();
    }
}
