using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForceBall : MonoBehaviour
{
    Rigidbody rb;
    Vector3 rollingDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    float timeElapsed = 0;
    void FixedUpdate(){
    
        rollingDirection += new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized * Time.deltaTime;
        rollingDirection = rollingDirection.normalized;
        rb.AddTorque(rollingDirection * 6f * Time.deltaTime, ForceMode.Impulse);
        
        

        

    }

    internal void Reset()
    {
        rollingDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }
}
