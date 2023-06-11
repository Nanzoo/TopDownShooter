using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 150f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cloneBul = Instantiate(bullet, transform.position, transform.rotation);
            Rigidbody cloneBulRB = cloneBul.GetComponent<Rigidbody>();

            cloneBulRB.AddForce(Vector3.up * speed);

            Destroy(cloneBul, 2.2f);
        }

    }
}


