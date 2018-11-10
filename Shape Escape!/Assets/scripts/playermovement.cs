using UnityEngine;

public class playermovement : MonoBehaviour {
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewaysforce = 500f;


    // Use this for initialization
    void Start() {


    }

    // Update is called once per frame
    void FixedUpdate() {

        rb.AddForce(0, 0, forwardforce * Time.fixedDeltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);

        }


        if (rb.position.y < 0)
        {
            FindObjectOfType<GameManager>().Endgame();
            FindObjectOfType<CrashScore>().Crash(rb.position.z);
        }
    }



}
