using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTeleport : MonoBehaviour
{
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball") //check that collider entering trigger is tagged "Ball"
        {
            if(other.TryGetComponent(out Rigidbody rb) == true) //Get rigidbody from colliding object
            {
                rb.velocity = Vector3.zero; //Reset rigidbody velocity to stop movement
            }
            other.transform.position = spawnPoint.position; //move colliding object to spawn point position
        }
    }
}
