using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame1 : MonoBehaviour
{
    public GameObject[] Spheres;
    public GameObject Instruction;
    public Movement1 movement;
    void Update()
    {
        if(Input.GetKey("p"))
        {
            for (int i = 0; i < Spheres.Length; i++)
            {
                Spheres[i].SetActive(true);
            }

            Instruction.SetActive(false);
            movement.enabled = true;
        }
    }

    public void Restart()
    {
        for (int i = 0; i < Spheres.Length; i++)
        {
            Spheres[i].SetActive(true);
            Spheres[i].GetComponent<Sphere1script>().RestartSphere();
        }
    }
}
