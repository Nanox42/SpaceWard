using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveData : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textScorePref;
    [SerializeField] private TextMeshProUGUI textTimerPref;

    void Start()
    {
        textScorePref.text = PlayerPrefs.GetString("ScorePref");
        textTimerPref.text = PlayerPrefs.GetString("TimePref");
    }

    private void Update()
    {
        ScorePref();
        TimerPref();
    }

    public void ScorePref()
    {
        PlayerPrefs.SetString("ScorePref", textScorePref.text);
    }

    public void TimerPref()
    {
        PlayerPrefs.SetString("TimePref", textTimerPref.text);
    }
}
