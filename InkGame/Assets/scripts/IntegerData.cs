using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class IntegerData : ScriptableObject
{

  public int value;

  public void SetValue(int num)
  {
    value = num;
  }

  public void CompareValue(IntegerData obj)
  {
    if (value >= obj.value)
    {
      
    }
    else
    {
      value = obj.value;
    }

  }

  public void SetValue(IntegerData obj)
  {
    value = obj.value;
  }

  public void UpdateValue(int num)
  {
    value += num;
  }

  
}
