using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject alvo;
    public float delay;
    void Start()
    {
        //alvo = this.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player")
        {
            Destroy(alvo.gameObject, delay);
        }
    }
}
