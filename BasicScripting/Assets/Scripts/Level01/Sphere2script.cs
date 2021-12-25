using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sphere2script : MonoBehaviour
{   
    public NextLevel1 nextlevel;
    public GameObject WinText;
    public GameObject TryItAgain;
    public GameObject Instruction;
    public GameObject Sphere2;
    public float delay = 2f;
    Vector3 originalPosSphere2;
    Vector3 originalPosPlayer;
    public GameObject Player;
    
    public void Start()
    {
        originalPosSphere2 = Sphere2.transform.position;
        originalPosPlayer = Player.transform.position;
    }
    void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {   
            Instruction.SetActive(false);
            WinText.SetActive(true);
            Invoke("NextLevel", delay);
            Sphere2.SetActive(false);

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
        Sphere2.transform.position = originalPosSphere2;
        Player.transform.position = originalPosPlayer;
        TryItAgain.SetActive(false);
    }

    void NextLevel()
    {
        nextlevel.enabled = true;
    }
}
