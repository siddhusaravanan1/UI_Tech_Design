using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehaviour : MonoBehaviour
{
    public void PlayScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void SkillTreeScene()
    {
        SceneManager.LoadScene("SkillTree");
    }
    public void StoreScene()
    {
        SceneManager.LoadScene("ShopMenu");
    }
    public void ExitGame()
    {
        Debug.Log("Exit");
    }
}
