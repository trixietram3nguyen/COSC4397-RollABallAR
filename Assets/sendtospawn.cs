using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendtospawn : MonoBehaviour
{
    public Transform spawnPoint;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = spawnPoint.position;
        Rigidbody otherObj = other.gameObject.GetComponent<Rigidbody>();
        //reset speed back to zero
        otherObj.angularVelocity = new Vector3(0, 0, 0);
        otherObj.velocity = new Vector3(0, 0, 0);
    }
}
