using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SkillTreeManager : MonoBehaviour
{
    public int skillCount;

    public GameObject MainPanel;
    public GameObject StrenghtPanel;
    public GameObject TenacityPanel;
    public GameObject VigorPanel;

    public TextMeshProUGUI skillCountText;

    public AudioSource mainSelectionSFX;
    private void Update()
    {
        skillCountText.text = "Skill count: " + skillCount;

        if(Input.GetKey(KeyCode.S))
        {
            skillCount = 10;
        }
    }
    public void StrenghtAccessMenu()
    {
        StrenghtPanel.SetActive(true);
        MainPanel.SetActive(false);
        mainSelectionSFX.Play();
    }
    public void TenacityAccessMenu()
    {
        TenacityPanel.SetActive(true);
        MainPanel.SetActive(false);
        mainSelectionSFX.Play();
    }
    public void VigorAccessMenu()
    {
        VigorPanel.SetActive(true);
        MainPanel.SetActive(false);
        mainSelectionSFX.Play();
    }
    public void BackToMainPanel()
    {
        StrenghtPanel.SetActive(false);
        TenacityPanel.SetActive(false);
        VigorPanel.SetActive(false);
        MainPanel.SetActive(true);
        mainSelectionSFX.Play();
    }
    public void BackToGameScene()
    {
        SceneManager.LoadScene("GameScene");
        mainSelectionSFX.Play();
    }
}
