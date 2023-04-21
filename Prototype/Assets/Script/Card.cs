using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject objectDrag;
    public GameObject objectGame;
    public Canvas canvas;
    private GameObject objectDragInstace;
    public void OnDrag(PointerEventData eventData)
    {
       
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
        objectDragInstace = Instantiate(objectDrag, canvas.transform);
        objectDragInstace.transform.position = Input.mousePosition;
        Debug.Log(Input.mousePosition);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
