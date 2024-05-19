using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrintData : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scorePrint;
    [SerializeField] private TextMeshProUGUI timePrint;

    void Start()
    {
        scorePrint.text = PlayerPrefs.GetString("ScorePref");
        timePrint.text = PlayerPrefs.GetString("TimePref");
    }


}
