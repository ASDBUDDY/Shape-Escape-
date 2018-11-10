using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {

 public void Restartscript()
    {
        Time.fixedDeltaTime = Time.deltaTime /2f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        

    }
}
