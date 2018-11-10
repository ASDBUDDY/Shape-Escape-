using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject CrashedUI;
    public float enddelay = 1f;
    bool gameend = false;
    bool level = false;
    public GameObject CompleteUI;
    public Button button1,button2;
    
    public void Endgame()
    {

        if (gameend == false)
        {
            button1.interactable = false;
            button2.interactable = false;
            gameend = true;
            CrashedUI.SetActive(true);
            Invoke("timepause", 3f);
        }
    }

    private  void timepause()
    {
        button1.interactable = true;
        button2.interactable = true;
    }


    public void Levelend()
    {

        if (level == false)
        {
            level = true;
            CompleteUI.SetActive(true);

        }
    }

}