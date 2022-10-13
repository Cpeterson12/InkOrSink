
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DragableBeaviour : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;
    public ID idObj;
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        var tempObj = Collider.GetComponent<IDContainerBehaviour>();
        
        if (tempObj == null)
            yield break;
        
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
            yield return new WaitForFixedUpdate();
            draggable = true;
            startDragEvent.Invoke();
        }

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
}
