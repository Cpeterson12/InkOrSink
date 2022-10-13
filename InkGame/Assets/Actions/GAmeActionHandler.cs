using UnityEngine;
using UnityEngine.Events;

public class GAmeActionHandler : MonoBehaviour
{
   public GAmeAction gameActionObj;
   public UnityEvent onRaiseEvent;
   private void Start()
   {
      gameActionObj.raise += Raise;
   }

   private void Raise()
   {
      onRaiseEvent.Invoke();
   }
}
