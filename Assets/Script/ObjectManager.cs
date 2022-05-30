using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ObjectManager : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    RectTransform recttransform;
    Canvas objcanvas;
    private void Awake()
    {
        recttransform = GetComponent<RectTransform>();
        objcanvas = gameObject.AddComponent<Canvas>();
        gameObject.AddComponent<GraphicRaycaster>();
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (CountDown.instance.TimeOn == true)
        {
            Debug.Log("OnDrag");
            recttransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }
        
    }   
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");
       
        objcanvas.overrideSorting = true;
        objcanvas.sortingOrder = 5;
    }
}















