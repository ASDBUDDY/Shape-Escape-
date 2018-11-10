using UnityEngine.SceneManagement;
using UnityEngine;

public class loadlevel2 : MonoBehaviour {

    int levelflag;
    private void Start()
    {
        levelflag = PlayerPrefs.GetInt("levelflag");
    }
    public void Leveldos()
    {
        if(levelflag < 2)
        {
            PlayerPrefs.SetInt("levelflag", 2);
        }
        Debug.Log(levelflag);
        SceneManager.LoadScene(2);
        GetComponent<restart>().Restartscript();
    }

}
