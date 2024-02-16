using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillMechanics : MonoBehaviour
{
    Button SkillUI;

    public SkillTreeManager skillTreeManager;

    public AudioSource selectionSFX;
    private void Start()
    {
        SkillUI = GetComponent<Button>();
    }
    public void OnPointerClick()
    {
        if(skillTreeManager.skillCount > 0)
        {
            SkillUI.interactable = false;
            Debug.Log("Skill = " + skillTreeManager.skillCount);
            skillTreeManager.skillCount -= 1;
            selectionSFX.Play();
        }
        else
        {
            Debug.Log("Not Enough Skill points");
        }
    }
}
