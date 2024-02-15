using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ShopUIManager : MonoBehaviour
{
    public GameObject feature1Panel;
    public GameObject feature2Panel;
    public GameObject DailyShop1Panel;
    public GameObject DailyShop2Panel;
    public GameObject DailyShop3Panel;
    public GameObject DailyShop4Panel;

    public GameObject f1OwnedText;
    public GameObject f2OwnedText;
    public GameObject d1OwnedText;
    public GameObject d2OwnedText;
    public GameObject d3OwnedText;
    public GameObject d4OwnedText;

    public Button Featured1UI;
    public Button Featured2UI;
    public Button DailyShop1UI;
    public Button DailyShop2UI;
    public Button DailyShop3UI;
    public Button DailyShop4UI;

    public GameObject shopContainerPanel;

    public int coinCount;

    public TextMeshProUGUI countText;



    private void Update()
    {
        countText.text = "Count = " + coinCount;
    }

    public void Feature1PanelAccess()
    {
        feature1Panel.SetActive(true);
        shopContainerPanel.SetActive(false);
    }
    public void Feature2PanelAccess()
    {
        feature2Panel.SetActive(true);
        shopContainerPanel.SetActive(false);
    }
    public void DailyShop1PanelAccess()
    {
        DailyShop1Panel.SetActive(true);
        shopContainerPanel.SetActive(false);
    }
    public void DailyShop2PanelAccess()
    {
        DailyShop2Panel.SetActive(true);
        shopContainerPanel.SetActive(false);
    }
    public void DailyShop3PanelAccess()
    {
        DailyShop3Panel.SetActive(true);
        shopContainerPanel.SetActive(false);
    }
    public void DailyShop4PanelAccess()
    {
        DailyShop4Panel.SetActive(true);
        shopContainerPanel.SetActive(false);
    }
    public void BackUI()
    {
        shopContainerPanel.SetActive(true);

        feature1Panel.SetActive(false);
        feature2Panel.SetActive(false);
        DailyShop1Panel.SetActive(false);
        DailyShop2Panel.SetActive(false);
        DailyShop3Panel.SetActive(false);
        DailyShop4Panel.SetActive(false);
    }
    public void AddCoins()
    {
        coinCount = 100;
        Debug.Log("Coins available = " + coinCount);
    }
    public void BackMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void buyFeatured1()
    {
        if(coinCount >= 50)
        {
            feature1Panel.SetActive(false);
            shopContainerPanel.SetActive(true);
            Featured1UI.interactable = false;
            f1OwnedText.SetActive(true);
            coinCount -= 50;
            Debug.Log("Coins available = " + coinCount);
        }
        else
        {
            Debug.Log("Not enough coin, remaining coins = " + coinCount);
        }
    }
    public void buyFeatured2()
    {
        if (coinCount >= 50)
        {
            feature2Panel.SetActive(false);
            shopContainerPanel.SetActive(true);
            Featured2UI.interactable = false;
            f2OwnedText.SetActive(true);
            coinCount -= 50;
            Debug.Log("Coins available = " + coinCount);
        }
        else
        {
            Debug.Log("Not enough coin, remaining coins = " + coinCount);
        }
    }
    public void buyDaily1()
    {
        if (coinCount >= 50)
        {
            DailyShop1Panel.SetActive(false);
            shopContainerPanel.SetActive(true);
            DailyShop1UI.interactable = false;
            d1OwnedText.SetActive(true);
            coinCount -= 50;
            Debug.Log("Coins available = " + coinCount);
        }
        else
        {
            Debug.Log("Not enough coin, remaining coins = " + coinCount);
        }
    }
    public void buyDaily2()
    {
        if (coinCount >= 50)
        {
            DailyShop2Panel.SetActive(false);
            shopContainerPanel.SetActive(true);
            DailyShop2UI.interactable = false;
            d2OwnedText.SetActive(true);
            coinCount -= 50;
            Debug.Log("Coins available = " + coinCount);
        }
        else
        {
            Debug.Log("Not enough coin, remaining coins = " + coinCount);
        }
    }
    public void buyDaily3()
    {
        if (coinCount >= 50)
        {
            DailyShop3Panel.SetActive(false);
            shopContainerPanel.SetActive(true);
            DailyShop3UI.interactable = false;
            d3OwnedText.SetActive(true);
            coinCount -= 50;
            Debug.Log("Coins available = " + coinCount);
        }
        else
        {
            Debug.Log("Not enough coin, remaining coins = " + coinCount);
        }
    }
    public void buyDaily4()
    {
        if (coinCount >= 50)
        {
            DailyShop4Panel.SetActive(false);
            shopContainerPanel.SetActive(true);
            DailyShop4UI.interactable = false;
            d4OwnedText.SetActive(true);
            coinCount -= 50;
            Debug.Log("Coins available = " + coinCount);
        }
        else
        {
            Debug.Log("Not enough coin, remaining coins = " + coinCount);
        }
    }

}
