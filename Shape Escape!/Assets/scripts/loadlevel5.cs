using UnityEngine.SceneManagement;
using UnityEngine;

public class loadlevel5 : MonoBehaviour {
    int levelflag;
    private void Start()
    {
        levelflag = PlayerPrefs.GetInt("levelflag");
    }
    public void Levelfive()
    {
        if (levelflag < 5)
        {
            PlayerPrefs.SetInt("levelflag", 5);
        }
        Debug.Log(levelflag);
        SceneManager.LoadScene(5);
        GetComponent<restart>().Restartscript();
    }

}
