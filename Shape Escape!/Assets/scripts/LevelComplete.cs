using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameManager gameManager;

    public void OnTriggerEnter(Collider box)
    {
        if (box.name == "player")
        {
            gameManager.Levelend();
        }
    }

}
