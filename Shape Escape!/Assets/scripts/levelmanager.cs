using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class levelmanager : MonoBehaviour {

    public int levelflag;
    public Button button1, button2, button3, button4;
    public GameObject UI1, UI2, UI3, UI4, UI5;

    private void Start()
    {
        levelflag = PlayerPrefs.GetInt("levelflag");
        button1.interactable = false;
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;

        switch(levelflag)
        {
            case 2: button1.interactable = true; break;
            case 3: button2.interactable = true;
                button1.interactable = true; break;
            case 4: button3.interactable = true;
                button2.interactable = true;
                button1.interactable = true; break;
            case 5:
                button4.interactable = true;
                button3.interactable = true;
                button2.interactable = true;
                button1.interactable = true; break;


        }
    }

    public void level1()
    {
        UI1.SetActive(true);
    }

    public void level2()
    {
        UI2.SetActive(true);
    }

    public void level3()
    {
        UI3.SetActive(true);
    }

    public void level4()
    {
        UI4.SetActive(true);
    }

    public void level5()
    {
        UI5.SetActive(true);
    }

    public void resetlevel()
    {
        button1.interactable = false;
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        PlayerPrefs.DeleteAll();

    }
}

