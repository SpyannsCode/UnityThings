using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using System.Collections;
using System.Collections.Generic;

public class MoveWindows : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    public float X, Y;
    public void OnDrag(PointerEventData eventData)
    {
        gameObject.transform.position = Input.mousePosition - new Vector3(X, Y, 0);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        transform.SetAsLastSibling();
        X = Input.mousePosition.x - gameObject.transform.position.x;
        Y = Input.mousePosition.y - gameObject.transform.position.y;
    }
}
