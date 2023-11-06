
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;//rb este prescurtarea de la Rigidbody

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Am adaugat o forta de miscare 


        if (Input.GetKey("d"))
        {

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }


        if (Input.GetKey("a"))
        {

            rb.AddForce(-sidewaysForce * Time.deltaTime,0, 0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
