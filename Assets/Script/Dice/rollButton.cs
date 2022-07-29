using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class rollButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventTrigger trigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        EventTrigger.Entry entry1 = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry1.eventID = EventTriggerType.PointerUp;
        entry.callback.AddListener((data) => { OnPointerDownDelegate((PointerEventData)data); });
        entry1.callback.AddListener((data) => { OnPointerUpDelegate((PointerEventData)data); });
    }
    public void OnPointerDownDelegate(PointerEventData data)
    {
        PowerUp.instancePowerUp.StartPowerUp();
        Debug.Log("OnpointerDownDelegate called.");
    }
    public void OnPointerUpDelegate(PointerEventData data)
    {
        PowerUp.instancePowerUp.EndPowerUp();
        Debug.Log("OnpointerUpDelegate called.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
