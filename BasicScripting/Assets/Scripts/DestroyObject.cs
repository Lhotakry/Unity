using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyObject : MonoBehaviour
{   
    public NextLevel nextlevel;
    public GameObject WinText;
    public GameObject TryItAgain;
    public GameObject Instruction;
    public GameObject Sphere;
    public float delay = 2f;
    Vector3 originalPosSphere;
    Vector3 originalPosPlayer;
    public GameObject Player;
    
    public void Start()
    {
        originalPosSphere = Sphere.transform.position;
        originalPosPlayer = Player.transform.position;
    }
    void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {   
            Instruction.SetActive(false);
            WinText.SetActive(true);
            Invoke("NextLevel", delay);
            Sphere.SetActive(false);

        }
        if(collision.gameObject.tag == "Ground")
        {
            Instruction.SetActive(false);
            TryItAgain.SetActive(true);
            Invoke("Restart", delay);
        }
    }
    void Restart()
    {
        Sphere.transform.position = originalPosSphere;
        Player.transform.position = originalPosPlayer;
        TryItAgain.SetActive(false);
    }

    void NextLevel()
    {
        nextlevel.enabled = true;
    }
}
