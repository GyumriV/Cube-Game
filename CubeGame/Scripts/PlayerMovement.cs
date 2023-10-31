using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public variables will be easily accessible from within the editor
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()  //Its better to use fixed update for Unity
    {
        //constant forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //get user input to move right //4th parameter of AddForce is the ForceMode
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);    //VelocityChange ignores objects mass
        }
        //get user input to move left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(transform.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
