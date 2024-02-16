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

    int subTextIndex = 0;
    int mainTextIndex = 0;
    //Method to subcribe to the current mission
    //Method to handle the animations
    private void Start()
    {
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
    }
    void NextKey()
    {
        DisplayNextKey();
    }
    void DisplayNextKey()
    {
        if (subTextIndex <= missionSystem[mainTextIndex].subMissions.Count)
        {
            Debug.Log(missionSystem[mainTextIndex].subMissions[subTextIndex]);
            subText.text = missionSystem[mainTextIndex].subMissions[subTextIndex];
            subTextIndex++;
        }
        else
        {
            Debug.Log("End of List");
        }
    }
}