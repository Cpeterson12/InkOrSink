
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DragableBeaviour : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;
    
    public bool isTouchingBoth;
    void Start()
    {
        cameraObj = Camera.main;
    }

    public void YesTouch()
    {
        isTouchingBoth = true;
    }
    public void NoTouch()
    {
        isTouchingBoth = false;
    }

    public IEnumerator OnMouseDown()
    {
        if (isTouchingBoth == true)
        {
            offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
            yield return new WaitForFixedUpdate();
            draggable = true;
            startDragEvent.Invoke();
            
            while (draggable)
            {
                yield return new WaitForFixedUpdate();
                position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
                transform.position = position;
            }
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
}
