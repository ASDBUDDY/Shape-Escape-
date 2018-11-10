using UnityEngine.SceneManagement;
using UnityEngine;

public class loadlevel4 : MonoBehaviour {
    int levelflag;
    private void Start()
    {
        levelflag = PlayerPrefs.GetInt("levelflag");
    }
    public void Levelfour()
    {
        if (levelflag < 4)
        {
            PlayerPrefs.SetInt("levelflag", 4);
        }
        Debug.Log(levelflag);
        SceneManager.LoadScene(4);
        GetComponent<restart>().Restartscript();
    }

}
