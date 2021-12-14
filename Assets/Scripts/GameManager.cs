using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers.DebugHandler;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text console;

    // Start is called before the first frame update
    void Start()
    {
        DebugManager.Instance.onLogEvent += OnLogEvent;
        DebugManager.Instance.Log("hello");
        DebugManager.Instance.Log("Hail to You");
        DebugManager.Instance.Log("Good Day");
        DebugManager.Instance.LogSeparater();
        DebugManager.Instance.Log("YEAH BOI~~");
    }

    private void OnLogEvent(string msg)
    {
        Debug.Log("Called");
        console.text = DebugManager.Instance.LogHistory;
        string msgCount = DebugManager.Instance.LogHistoryList.Count.ToString();
        console.text += "Count: " + DebugManager.SetTextColor(msgCount, DebugManager.TextColor.lime);
    }
}
