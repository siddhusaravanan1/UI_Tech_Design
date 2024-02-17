using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MissionReportBehaviour : MonoBehaviour
{
    [SerializeField]
    private List<MissionSystem> missionSystem;
    [SerializeField]
    private RectTransform mainTextTransform;
    [SerializeField]
    private RectTransform subTextTransform;
    [SerializeField]
    private TextMeshProUGUI mainText;
    [SerializeField]
    private TextMeshProUGUI subText;

    public GameObject weaponWheelPanel;

    int subTextIndex = 0;
    int mainTextIndex = 0;
    //Method to subcribe to the current mission
    //Method to handle the animations
    private void Start()
    {
        missionSystem[mainTextIndex].isCompleted = false;
        mainText.text = missionSystem[mainTextIndex].missionName;
        subText.text = missionSystem[mainTextIndex].subMissions[subTextIndex];

        Debug.Log(missionSystem[0].subMissions[0]);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            NextKey();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("SkillTree");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            weaponWheelPanel.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            weaponWheelPanel.gameObject.SetActive(false);
        }

    }
    void NextKey()
    {
        DisplayNextKey();
        if (missionSystem[mainTextIndex].isCompleted)
        {
            NextMission();
        }
    }

    void DisplayNextKey()
    {
        if (subTextIndex < missionSystem[mainTextIndex].subMissions.Count)
        {
            Debug.Log(missionSystem[mainTextIndex].subMissions[subTextIndex]);
            subText.text = missionSystem[mainTextIndex].subMissions[subTextIndex];
            subTextIndex++;
        }
        else
        {
            Debug.Log("End of List");
            missionSystem[mainTextIndex].isCompleted = true;
        }
    }
    void NextMission()
    {
        mainTextIndex++;
        missionSystem[mainTextIndex].isCompleted = false;
        Debug.Log(mainTextIndex);
        mainText.text = missionSystem[mainTextIndex].missionName;
        subTextIndex = 0;
        subText.text = missionSystem[mainTextIndex].subMissions[subTextIndex];
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}