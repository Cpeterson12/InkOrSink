using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider))]

public class TriggerEventBehaviour : MonoBehaviour
{
   public UnityEvent triggerEnterEvent;
   public UnityEvent powerUpReset;
   public IntegerData time;
   public int timeReset = 5;
   private void OnTriggerEnter(Collider other)
   {
      triggerEnterEvent.Invoke();
      StartCoroutine(Timer());
   }

   private void AfterEvent()
   {
      powerUpReset.Invoke();
   }
   
   public IEnumerator Timer()
   {
      while (time.value > 0)
      {
         yield return new WaitForSeconds(1.0f);
         time.value--;
      }

      time.value = timeReset;
      AfterEvent();
   }
   
}
