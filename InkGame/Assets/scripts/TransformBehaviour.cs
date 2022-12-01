using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class TransformBehaviour : MonoBehaviour
{
    public Vector3Datas Position;
    public void ResetToZero()
    {
        transform.position = Position.value;
    }
    
}
