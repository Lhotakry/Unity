using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1200f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime); // forward movement of player ( in-game rightway force)
    
    if ( Input.GetKey("d") ){
        rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    if ( Input.GetKey("a") ){
        rb.AddForce(-sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    if (rb.position.y < -1f)
    {
        FindObjectOfType<GameManage>().GameOver();
    }
    
    }


    
}
