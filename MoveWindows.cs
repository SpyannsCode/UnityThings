using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using System.Collections;
using System.Collections.Generic;

public class MoveWindows : MonoBehaviour, IDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public float X, Y;
    private bool MouseOver = false;
    public void OnPointerEnter(PointerEventData eventData)
    {
        MouseOver = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        MouseOver = false;
    }
    void Update()
    {
        if (MouseOver)
        {
            X = Input.mousePosition.x - gameObject.transform.position.x;
            Y = Input.mousePosition.y - gameObject.transform.position.y;
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.SetAsLastSibling();
        gameObject.transform.position = Input.mousePosition - new Vector3(X, Y, 0);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        transform.SetAsLastSibling();
        gameObject.transform.position = Input.mousePosition - new Vector3(X, Y, 0);
    }
}
