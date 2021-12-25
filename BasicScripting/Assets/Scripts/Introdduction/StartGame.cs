using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject Instruction;
    public Movement movement;
    void Update()
    {
        if(Input.GetKey("p"))
        {
        Sphere.SetActive(true);
        Instruction.SetActive(false);
        movement.enabled = true;
        }
    }
}
