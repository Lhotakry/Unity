using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame1 : MonoBehaviour
{
    public GameObject Sphere1;
    public GameObject Sphere2;
    public GameObject Instruction;
    public Movement1 movement;
    void Update()
    {
        if(Input.GetKey("p"))
        {
        Sphere1.SetActive(true);
        Sphere1.SetActive(true);
        Instruction.SetActive(false);
        movement.enabled = true;
        }
    }
}
