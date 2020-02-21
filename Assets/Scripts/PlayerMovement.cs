using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // FixedUpdate es mejor para calcular las fisicas 
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {

            FindObjectOfType<Manager>().EndGame();
        }
    }
}
