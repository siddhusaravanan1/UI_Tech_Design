using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillMechanics : MonoBehaviour
{
    Button SkillUI;
    private void Start()
    {
        SkillUI = GetComponent<Button>();
    }
    public void OnPointerClick()
    {
        SkillUI.interactable = false;
        Debug.Log("Skill -1");
    }
}
