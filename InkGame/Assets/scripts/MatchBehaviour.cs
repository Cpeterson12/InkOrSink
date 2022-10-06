using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent startEvent, matchEvent, onLeaveMatchEvent, noMatchEvent, noMatchDelayedEvent;
    public IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        
        if (tempObj == null)
            yield break;
        
        var otherID = tempObj.idObj;
       
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
        
       
    }
    void OnTriggerExit(Collider idObj)
    {
        onLeaveMatchEvent.Invoke();
        Debug.Log("work??");
    }
}
