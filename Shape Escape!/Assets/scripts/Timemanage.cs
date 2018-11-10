using UnityEngine;

public class Timemanage : MonoBehaviour
{

    public float slowdownfactor = 0.05f;
    public float slowdownlength = 2f;

    private void Update()
    {
        Time.timeScale += (1f / slowdownlength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

    public void Doslowmotion()
    {
        Time.timeScale = slowdownfactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}
	
