using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    Quaternion tilt;
    Quaternion lR = Quaternion.Euler(270,0,45);
    Quaternion rR = Quaternion.Euler(270, 0, -45);
    Quaternion regR = Quaternion.Euler(270, 0, 0);

    Transform myT;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tilt = regR;
       
    }


    // Update is called once per frame
    void Update()
    {

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * 15 * Time.deltaTime, relativeTo:Space.World);
            tilt = rR;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            tilt = regR;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * 15 * Time.deltaTime, relativeTo: Space.World);
            tilt = lR;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            tilt = regR;
        }
        transform.rotation = Quaternion.Slerp(transform.rotation, tilt, Time.deltaTime * 7);
        //if (Input.GetKey(KeyCode.UpArrow))
        //   transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        // if (Input.GetKey(KeyCode.DownArrow))
        // transform.Translate(Vector3.back * 10 * Time.deltaTime);
        
       
    }
    
}
