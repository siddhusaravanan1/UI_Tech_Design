using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseHoverInput : MonoBehaviour
{
    public void OnPointerEnter()
    {
        GameObject panel = transform.GetChild(1).gameObject;
        Debug.Log(panel.gameObject.name);
        panel.SetActive(true);
    }
    public void OnPointerExit()
    {
        GameObject panel = transform.GetChild(1).gameObject;
        panel.SetActive(false);
    }
}
