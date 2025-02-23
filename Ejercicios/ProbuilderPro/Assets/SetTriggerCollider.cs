using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTriggerCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }
}
