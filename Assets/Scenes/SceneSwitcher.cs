using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}