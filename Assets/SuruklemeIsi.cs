using UnityEngine;
using UnityEngine.EventSystems;

public class SuruklemeIsi : MonoBehaviour,IDragHandler,IEndDragHandler,IPointerDownHandler,IPointerUpHandler
{

    public GameObject Panel;
    Vector3 ilkpoziyon;
    void Start()
    {
        ilkpoziyon = transform.position;
        
    }

    public void OnDrag(PointerEventData eventData)
    {
      
        transform.position = Input.mousePosition;       

    }

    public void OnEndDrag(PointerEventData eventData)
    {
       
        float mesafe = Vector3.Distance(transform.position , Panel.transform.position);

        if (mesafe<160)
        {
            transform.SetParent(Panel.transform);

        }
        else
        {

            transform.position = ilkpoziyon;
        }
       // Debug.Log(mesafe.ToString());
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("basıldı");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("bırakıldı");
    }
}
