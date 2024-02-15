using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public string skillName;
    public List<Skill> dependencies = new List<Skill>();
    public bool unlocked;
}
