using UnityEngine;
using System.Collections;

public class HoverPad : MonoBehaviour
{   
    void OnTriggerStay (Collider other)
    {
        other.rigidbody.AddForce(Vector3.up * 100, ForceMode.Acceleration);
        other.rigidbody.useGravity = true	
    }
}