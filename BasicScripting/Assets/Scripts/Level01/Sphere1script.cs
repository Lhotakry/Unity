using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sphere1script : MonoBehaviour
{   
    public GameObject TryItAgain;
    public NextLevel1 nextlevel;
    public GameObject WinText;
    public GameObject Instruction;
    public static int SphereCount = 2;
    public float delay = 2f;
    Vector3 originalPosSphere;
    Vector3 originalPosPlayer;
    public GameObject Player;
    
    public void Start()
    {
        originalPosSphere = this.transform.position;
        originalPosPlayer = Player.transform.position;
    }
    void OnCollisionEnter(Collision collision)
   {
        if(collision.gameObject.tag == "Player")
        {   
            Instruction.SetActive(false);
            this.gameObject.SetActive(false);
            SphereCount --;
            Debug.Log(SphereCount);
            if (SphereCount<=0)
            {
                WinText.SetActive(true);
                Invoke("NextLevel", delay);
            }

        }
        if(collision.gameObject.tag == "Ground")
        {
            Instruction.SetActive(false);
            TryItAgain.SetActive(true);
            Invoke("RestartGlobal", delay);
        }
    }
    void RestartGlobal()
    {
        Player.GetComponent<StartGame1>().Restart();
    }
    public void RestartSphere()
    {
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        this.transform.position = originalPosSphere;
        Player.transform.position = originalPosPlayer;
        TryItAgain.SetActive(false);
    }
     void NextLevel()
    {
        nextlevel.enabled = true;
    }
}
