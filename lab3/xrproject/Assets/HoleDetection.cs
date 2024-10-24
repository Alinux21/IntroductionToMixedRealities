using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleDetection : MonoBehaviour
{
    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {

        initialPosition = transform.position;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlackSphere"))
        {
            transform.position = initialPosition;
            FindObjectOfType<ScoreManager>().AddScore();


            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
