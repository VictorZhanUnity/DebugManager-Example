using UnityEngine;
using UnityEngine.UI;
using Debug = Managers.DebugHandler.DebugManager;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text console;

    // Start is called before the first frame update
    void Start()
    {
        Debug.IsActivated = true;
        Debug.isRecord = true;
        Debug.onLogEvent += OnLogEvent;
        Debug.Log("hello");
        Debug.Log("Hail to You");
        Debug.Log("Good Day");
        Debug.LogSeparater();
        Debug.Log($"IsActivated: {Debug.IsActivated}");
        Debug.Log($"isRecord: {Debug.isRecord}");
    }

    /// <summary>
    /// 進行Debug.Log之後觸發的Event
    /// </summary>
    private void OnLogEvent(string msg)
    {
        console.text = Debug.LogHistory;
        string msgCount = Debug.LogHistoryList.Count.ToString();
        console.text += "Count: " + Debug.SetTextColor(msgCount, Debug.TextColor.lime);
    }
}
