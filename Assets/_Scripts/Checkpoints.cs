using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public static Vector3 lastposition;
    public bool saved;
    public Transform spawn;
    public GameObject particles;

    void Start()
    {
        saved = false;
        lastposition = spawn.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            lastposition = other.transform.position;
            saved = true;
            Destroy(particles);
        }
    } 
}
