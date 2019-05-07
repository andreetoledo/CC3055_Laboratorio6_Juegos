using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vueltas : MonoBehaviour
{
    Vector3 vector = new Vector3(0, 0, 0);
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down * 90 * Time.deltaTime);
    }

   
}
