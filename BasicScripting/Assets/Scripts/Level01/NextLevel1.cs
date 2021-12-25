using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel1 : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
