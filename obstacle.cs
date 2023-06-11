using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    float delay = 1.00f;
    public GameObject cube;
    GameObject cloneCube;
    bool repeater;
    int x = 0;
    int y = 0;
    int i = 0; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", delay, delay);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void Spawn()
    {
        if (x<6)
        {
            transform.position = new Vector3(-7, 9, 1);
            cloneCube = Instantiate(cube, transform.position, transform.rotation);
            Rigidbody cloneCubeRB = cloneCube.GetComponent<Rigidbody>();
            cloneCubeRB.AddForce(Vector3.down * 90);
            StartCoroutine(ChangePath());
            Destroy(cloneCube, 10f);
            x++;
             IEnumerator ChangePath()
            {
                yield return new WaitForSeconds(2.75f);
                cloneCubeRB.AddForce(Vector3.right * 175);
            }
        }
        if(x>=6 && y<18+i)
        {
            y++;
        }
        if(x>=6 && y>=18+i)
        {
            x = 0;
            y = 0;
            i=3;
        }



    }
}
