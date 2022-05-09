using UnityEngine;
using UnityEngine.SceneManagement;

public class optionsHelper : MonoBehaviour
{
    public void LoadScene() {
        SceneManager.LoadScene("MainMenuCutSceneDemo");
    }
    public void QuitToDecktop() {
        Application.Quit();
    }
}
