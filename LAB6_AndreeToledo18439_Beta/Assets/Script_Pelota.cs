using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Pelota : MonoBehaviour
{
    bool enSuelo;
    Vector3 v = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        enSuelo = true;
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        
            if (Input.GetKey(KeyCode.A))
                rb.AddForce(Vector3.left * 100 * Time.deltaTime);

            if (Input.GetKey(KeyCode.D))
                rb.AddForce(Vector3.right * 100 * Time.deltaTime);

            if (Input.GetKey(KeyCode.S))
                rb.AddForce(Vector3.back * 100 * Time.deltaTime);

            if (Input.GetKey(KeyCode.W))
                rb.AddForce(Vector3.forward * 100 * Time.deltaTime);

        if (enSuelo)
        {
            if (Input.GetKey(KeyCode.Space))
            {

            
                rb.velocity = new Vector3(0f, 3f, 0f);
                rb.AddForce(Vector3.up * 100 * Time.deltaTime);
            enSuelo = false;
            }
        }


    
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fueeego")
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Suelo"))
        {
            enSuelo = true;
        }
    }

}
