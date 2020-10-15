using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 20f;
    public float sidewaysForce = 20f;

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddRelativeForce(Vector3.forward * forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
