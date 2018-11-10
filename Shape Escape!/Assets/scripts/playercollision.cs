using UnityEngine;
using UnityEngine.UI;

public class playercollision : MonoBehaviour {
    public playermovement movement;
    public float Crashdistance = 0f;
    public Transform player;
    public Timemanage timeManager;
    public float framerate;
    public bool flagset = false;

    


    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle") 
        {
            if (flagset == false)
            {
                flagset = true;
                movement.enabled = false;
                framerate = Time.fixedDeltaTime;
                Crashdistance = player.position.z;
                timeManager.Doslowmotion();
                FindObjectOfType<GameManager>().Endgame();
                FindObjectOfType<CrashScore>().Crash(Crashdistance);
            }
            




        }

    }

    


}
