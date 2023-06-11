using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colider : MonoBehaviour
{
    public GameObject explode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        //collision.gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Renderer>().enabled = false;
        Destroy(gameObject,1.0f);
        Destroy(collision.gameObject);
        GameObject explodeClone = Instantiate(explode, transform.position, Quaternion.identity);
        explodeClone.GetComponent<ParticleSystem>().Play();
        Destroy(explodeClone, 2.0f);

    }
}
