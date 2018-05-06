using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody rb;
    public float forwardspeed;
    public float sidewayspeed;

    void Start()                                        //called at the start of the game
    {
        rb = GetComponent<Rigidbody>();                 //get component rigidbody from the object
    }

    void FixedUpdate()                                  //called every fixed time for physic calculation
    {
        rb.AddForce(0f, 0f, forwardspeed * Time.deltaTime);    //add force in Z direction

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayspeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayspeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y<-1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
