using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstancerBehaviour : MonoBehaviour
{
    public GameObject prefab;
    private int num;
    public Transform playerLoc;
    public float forward = 6.0f;
    private GameObject newInstance;
    public void CreateInstance()
    {
        CallForInstance();
        newInstance = Instantiate(prefab, transform.position, transform.rotation);
        
    }

    public void CallForInstance()
    {
        StartCoroutine(CheckForInstance());
    }
    public IEnumerator CheckForInstance()
    {
        int inkNumber = GameObject.FindGameObjectsWithTag("Ink").Length;
        if (inkNumber >= 1)
        {
            Destroy(newInstance);
        }

        yield return null;

    }

    public void CreateInstance(Vector3Datas obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        foreach (var t in obj.vector3DList)
        {
            Instantiate(prefab, t.value, Quaternion.identity);
        }
    }

    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
        num++;
        if (num == obj.vector3DList.Count)
        {
            num = 0;
        }
    }
   
    public void CreateInstanceListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3DList.Count - 1);
        Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
    }
}
