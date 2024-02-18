using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehaviour : MonoBehaviour
{
    public AudioSource menuSelectionSFX;
    public void PlayScene()
    {

        menuSelectionSFX.Play();
        SceneManager.LoadScene("GameScene");
    }
    public void SkillTreeScene()
    {
        SceneManager.LoadScene("SkillTree");
    }
    public void StoreScene()
    {
        menuSelectionSFX.Play();
        SceneManager.LoadScene("ShopMenu");
    }
    public void ExitGame()
    {
        menuSelectionSFX.Play();
        Application.Quit();
    }
}
