using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerEventSender : MonoBehaviour
{
    public UnityEvent onTriggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere") 
        {
            onTriggerEvent.Invoke(); 
        }
    }
}
