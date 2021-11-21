using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Referencia al componente de RigidBody llamado rb
    public Rigidbody rb;
    public float sidewaysForce = 500f;
    public float forwardForce = 2000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // FixedUpdate porque eso se usa para weas físicas
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0,0,forwardForce* Time.deltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")){
            rb.AddForce(-sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
