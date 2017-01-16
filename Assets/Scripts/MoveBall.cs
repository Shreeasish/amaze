using UnityEngine;
using System.Collections;

public class MoveBall: MonoBehaviour
{

    public float speed;
    
    Light pointLight;

    Material material;

    public float key;
    

    private Rigidbody rb;

    public float Key
    {
        get
        {
            return key;
        }
        set
        {
            key = value;
        }
    }

    void Victory()
    {
        GetComponent<MoveBall>().enabled = false;
    }


    void Start()
    {
        //childGO = transform.FindChild("Point light").gameObject;
        //pointLight = childGO.GetComponent<Light>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //material.shader. pointLight.intensity;

    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.acceleration.y;
        float moveVertical = -Input.acceleration.x;
        float moveZ = Input.acceleration.z;

        Vector3 movement = new Vector3(moveHorizontal, moveZ, moveVertical);

        rb.AddForce(movement * speed);
    }

    

}
