using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private Vector3 last;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        last = rb.velocity;
    }

    private void OnCollisionEnter(Collision other) {
        var speed = last.magnitude;
        var direction = Vector3.Reflect(last.normalized, other.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
    }
}
