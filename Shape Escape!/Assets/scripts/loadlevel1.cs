using UnityEngine.SceneManagement;
using UnityEngine;

public class loadlevel1 : MonoBehaviour {
	public void Leveluno()
    {
        SceneManager.LoadScene(1);
        GetComponent<restart>().Restartscript();
    }

}
