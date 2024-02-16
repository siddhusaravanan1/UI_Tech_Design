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
    public Image hoverImage;

    public Sprite icon;
    public Sprite icon1;
    public Sprite hoverIcon;

    public string itemName;
    public string weaponDetailsText;

    public TextMeshProUGUI weaponNameText;
    public TextMeshProUGUI weaponDetails;

    public GameObject textObject;
    public GameObject pointer;

    bool selected;
    bool hover;

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
        if(hover)
        {
            hoverImage.sprite = hoverIcon;
            hoverImage.SetNativeSize();
            hoverImage.preserveAspect = true;
            pointer.SetActive(true);

            weaponDetails.text = weaponDetailsText;
        }
    }
    public void Hovering()
    {
        hover = true;
    }
    public void HoverExit()
    {
        hover = false;
        pointer.SetActive(false);
    }
    public void Selected()
    {
        selected = true;
        gunChangeSFX.Play();
    }
    public void deselected()
    {
        selected = false;
    }
    public void EmptySelected()
    {
        weaponNameText.text = itemName;
    }
    public void emptyHovering()
    {
        hoverImage.enabled = false;
        weaponDetails.text = weaponDetailsText;
        pointer.SetActive(true);
    }
    public void emptyHoverExit()
    {
        hoverImage.enabled = true;
        weaponDetails.text = weaponDetailsText;
        pointer.SetActive(false);
    }
}
