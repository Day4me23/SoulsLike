using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    private Character inputActions;
    private void Start()
    {
        if (inputActions == null)
            inputActions = new Character();
        inputActions.PlayerActions.Menu.performed += ctx => pauseMenu.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
