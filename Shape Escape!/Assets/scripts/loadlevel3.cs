using UnityEngine.SceneManagement;
using UnityEngine;

public class loadlevel3 : MonoBehaviour {
    int levelflag;
    private void Start()
    {
        levelflag = PlayerPrefs.GetInt("levelflag");
    }
    public void Leveltres()
    {
        if (levelflag < 3)
        {
            PlayerPrefs.SetInt("levelflag", 3);
        }
        Debug.Log(levelflag);
        SceneManager.LoadScene(3);
        GetComponent<restart>().Restartscript();
    }

}
