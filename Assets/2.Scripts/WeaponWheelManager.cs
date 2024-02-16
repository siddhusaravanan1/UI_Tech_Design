using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class WeaponWheelManager : MonoBehaviour
{
    public int id;
    public Image selectedImage;
    public Sprite icon;

    bool selected;

    private void Update()
    {
        if(selected)
        {
            selectedImage.sprite = icon;
            selectedImage.preserveAspect = true;
        }
    }
    public void Selected()
    {
        selected = true;
    }
    public void deselected()
    {
        selected = false;
    }
}
