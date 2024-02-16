using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillPointManager : MonoBehaviour
{
    public SkillTreeManager skillTreeManager;

    [SerializeField]
    Button firstUnlockInt;
    [SerializeField]
    Button[] secondUnlockInt;
    [SerializeField]
    Button[] thirdUnlockInt;
    [SerializeField]
    Button[] fourthUnlockInt;
    [SerializeField]
    Button[] fifitUnlockInt;
    [SerializeField]
    Button[] sixthUnlockInt;
    [SerializeField]
    Button[] seventhUnlockInt;

    public void FirstUnlock()
    {
        foreach (Button button in secondUnlockInt)
        {
            if (skillTreeManager.skillCount > 0)
            {
                button.interactable = true;
            }
            else
            {
                Debug.Log("Null");
            }
        }
    }
    public void SecondUnlock()
    {
        foreach (Button button in thirdUnlockInt)
        {
            if (skillTreeManager.skillCount > 0)
            {
                button.interactable = true;
            }
            else
            {
                Debug.Log("Null");
            }
        }
    }
    public void ThirdUnlock()
    {
        foreach (Button button in fourthUnlockInt)
        {
            if (skillTreeManager.skillCount > 0)
            {
                button.interactable = true;
            }
            else
            {
                Debug.Log("Null");
            }
        }
    }
    public void FourthUnlock()
    {
        foreach (Button button in fifitUnlockInt)
        {
            if (skillTreeManager.skillCount > 0)
            {
                button.interactable = true;
            }
            else
            {
                Debug.Log("Null");
            }
        }
    }
    public void FifthUnlock()
    {
        foreach (Button button in sixthUnlockInt)
        {
            if (skillTreeManager.skillCount > 0)
            {
                button.interactable = true;
            }
            else
            {
                Debug.Log("Null");
            }
        }
    }

    public void SixthUnlock()
    {
        foreach (Button button in seventhUnlockInt)
        {
            if (skillTreeManager.skillCount > 0)
            {
                button.interactable = true;
            }
            else
            {
                Debug.Log("Null");
            }
        }
    }
}
