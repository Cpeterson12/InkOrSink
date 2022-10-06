using UnityEngine;

[CreateAssetMenu]
//floatdata is inherited from scriptableobject
public class FloatDatas : ScriptableObject
{
    public float value;

    public void SetValue(float num)
    {
        value = num;
    }
  
    public void UpdateValue(float num)//num is the updated value
    {
        value += num;
    }
}