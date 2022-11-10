using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingBehaviour : MonoBehaviour
{
    public List<Transform> poolList;
    
    private WaitForSeconds wfsObj;
    public float seconds = 2.0f;
    private int i;
    private int num;
    private int randObj;
    public Vector3DataList obj;
   
    IEnumerator BeginPool()
    {
        wfsObj = new WaitForSeconds(seconds);
        while (true)
        {
            yield return wfsObj;
            num = Random.Range(0, obj.vector3DList.Count - 1);
            randObj = Random.Range(0, poolList.Count - 1);
            poolList[randObj].position = obj.vector3DList[num].value;
            poolList[randObj].gameObject.SetActive(true);
           // i++;
           // if (i > poolList.Count - 1)
           // {
            //    i = 0;
           // }

        }
    }

    public void ActivatePool()
    {
        StartCoroutine(BeginPool());
    }
}
