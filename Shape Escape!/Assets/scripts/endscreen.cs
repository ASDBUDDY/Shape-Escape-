using UnityEngine.SceneManagement;
using UnityEngine;

public class endscreen : MonoBehaviour {

	public void Levelendscreen()
    {
        SceneManager.LoadScene(6);
        GetComponent<restart>().Restartscript();
    }

}
