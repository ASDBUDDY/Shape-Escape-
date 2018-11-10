using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {
    public levelmanager levelManager;
    public GameObject leveluno;

    public void Playgame()
    {
        if(levelManager.levelflag <2 && levelManager.levelflag >5)
        {
            levelManager.levelflag = 1;
        }
        leveluno.SetActive(true);
    }
    
    public void Levels()
    {
        SceneManager.LoadScene(7);

    }


    public void Quitgame()

    {
        Application.Quit();

    }

}
