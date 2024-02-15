using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUIManager : MonoBehaviour
{
    public GameObject Featured1Panel;
    public GameObject Featured2Panel;
    public GameObject DailyShop1Panel;
    public GameObject DailyShop2Panel;
    public GameObject DailyShop3Panel;
    public GameObject DailyShop4Panel;

    public Button Featured1UI;
    public Button Featured2UI;
    public Button DailyShop1UI;
    public Button DailyShop2UI;
    public Button DailyShop3UI;
    public Button DailyShop4UI;

    public void Featured1PanelAccess()
    {
        Featured1Panel.SetActive(true);
        Featured1UI.interactable = false;
        Featured2UI.interactable = false;
        DailyShop1UI.interactable = false;
        DailyShop2UI.interactable = false;
        DailyShop3UI.interactable = false;
        DailyShop4UI.interactable = false;
    }
    public void Featured2PanelAccess()
    {
        Featured2Panel.SetActive(true);
        Featured1UI.interactable = false;
        Featured2UI.interactable = false;
        DailyShop1UI.interactable = false;
        DailyShop2UI.interactable = false;
        DailyShop3UI.interactable = false;
        DailyShop4UI.interactable = false;
    }
    public void DailyShop1PanelAccess()
    {
        DailyShop1Panel.SetActive(true);
        Featured1UI.interactable = false;
        Featured2UI.interactable = false;
        DailyShop1UI.interactable = false;
        DailyShop2UI.interactable = false;
        DailyShop3UI.interactable = false;
        DailyShop4UI.interactable = false;
    }
    public void DailyShop2PanelAccess()
    {
        DailyShop2Panel.SetActive(true);
        Featured1UI.interactable = false;
        Featured2UI.interactable = false;
        DailyShop1UI.interactable = false;
        DailyShop2UI.interactable = false;
        DailyShop3UI.interactable = false;
        DailyShop4UI.interactable = false;
    }
    public void DailyShop3PanelAccess()
    {
        DailyShop3Panel.SetActive(true);
        Featured1UI.interactable = false;
        Featured2UI.interactable = false;
        DailyShop1UI.interactable = false;
        DailyShop2UI.interactable = false;
        DailyShop3UI.interactable = false;
        DailyShop4UI.interactable = false;
    }
    public void DailyShop4PanelAccess()
    {
        DailyShop4Panel.SetActive(true);
        Featured1UI.interactable = false;
        Featured2UI.interactable = false;
        DailyShop1UI.interactable = false;
        DailyShop2UI.interactable = false;
        DailyShop3UI.interactable = false;
        DailyShop4UI.interactable = false;
    }
    public void BackUI()
    {
        Featured1Panel.SetActive(false);
        Featured2Panel.SetActive(false);
        DailyShop1Panel.SetActive(false);
        DailyShop2Panel.SetActive(false);
        DailyShop3Panel.SetActive(false);
        DailyShop4Panel.SetActive(false);
        //
        Featured1UI.interactable = true;
        Featured2UI.interactable = true;
        DailyShop1UI.interactable = true;
        DailyShop2UI.interactable = true;
        DailyShop3UI.interactable = true;
        DailyShop4UI.interactable = true;
    }
}
