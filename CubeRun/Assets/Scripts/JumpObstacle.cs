using UnityEngine;

public class JumpObstacle : MonoBehaviour
{
    public Rigidbody rb;
    public float JumpForce = 500f;
    void OnCollisionEnter (Collision collisionInfo){
        if (collisionInfo.collider.tag == "JumpObstacle"){
            rb.AddForce(0, JumpForce, 0);
        }
    }


}
