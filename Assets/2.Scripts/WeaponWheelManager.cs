using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponWheelManager : MonoBehaviour
{
    public int id;
    public Image selectedImage;
    public Image selectedImage1;

    public Sprite icon;
    public Sprite icon1;

    public string itemName;

    public TextMeshProUGUI weaponNameText;
    public GameObject textObject;

    bool selected;

    public AudioSource gunChangeSFX;
    private void Update()
    {
        if(selected)
        {
            selectedImage.sprite = icon;
            selectedImage.preserveAspect = true;
            selectedImage.SetNativeSize();

            selectedImage1.sprite = icon1;
            selectedImage1.preserveAspect = true;
            selectedImage1.SetNativeSize();

            textObject.SetActive(true);
            weaponNameText.text = itemName;
        }
    }
    public void Selected()
    {
        selected = true;
        gunChangeSFX.Play();
    }
    public void EmptySelected()
    {
        weaponNameText.text = itemName;
    }
    public void deselected()
    {
        selected = false;
    }
}
