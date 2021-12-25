using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sphere1script : MonoBehaviour
{   
    public GameObject TryItAgain;
    public GameObject Instruction;
    public GameObject Sphere1;
    public float delay = 2f;
    Vector3 originalPosSphere;
    Vector3 originalPosPlayer;
    public GameObject Player;
    
    public void Start()
    {
        originalPosSphere = Sphere1.transform.position;
        originalPosPlayer = Player.transform.position;
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Instruction.SetActive(false);
            TryItAgain.SetActive(true);
            Invoke("Restart", delay);
        }
    }
    void Restart()
    {
        Sphere1.transform.position = originalPosSphere;
        Player.transform.position = originalPosPlayer;
        TryItAgain.SetActive(false);
    }
}
