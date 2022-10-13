using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu]
public class GAmeAction : ScriptableObject
{
   public UnityAction raise;

   public void RaiseAction()
   {
      raise?.Invoke();
   }
}
