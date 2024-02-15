using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class TestSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelBarrier1;
    public GameObject panelBarrier2;

    Button panel1button;
    Button[] panel2button;

    private void Start()
    {
        panel2button = panelBarrier2.GetComponentsInChildren<Button>();
    }
    public void FirstUnlock()
    {
        panel1button = panelBarrier1.GetComponentInChildren<Button>();
        panel1button.interactable = true;
    }
    public void SecondUnlock()
    {
        foreach (Button button in panel2button)
        {
            button.interactable = true;
        }
    }
}
