using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    void Start()
    {
        if (GameOverSingleton.Instance.GameOver)
        {
            EventTrigger trigger = GetComponent<EventTrigger>();
            EventTrigger.Entry entry = new EventTrigger.Entry();
            entry.eventID = EventTriggerType.PointerDown;
            entry.callback.AddListener((data) => { OnPointerClick((PointerEventData)data); });
            trigger.triggers.Add(entry);
        }
    }

    public void OnPointerClick(PointerEventData data)
    {
        SceneManager.LoadScene(0);
    }
}
