using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject image;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        image = GameObject.Find("BgImage");
        button = GetComponent<Button>();
        button.onClick.AddListener(Bye);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Bye()
    {
        if(image.activeSelf == true)
        {
            image.SetActive(false);
        }
        else
        {
            image.SetActive(true);
        }
        
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        //image.SetActive(false);
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        //image.SetActive(true);
    }
}
