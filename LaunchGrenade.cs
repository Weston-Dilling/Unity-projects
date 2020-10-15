using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class LaunchGrenade : MonoBehaviour
{
    public GameObject CannonBallPrefab;

    private Transform myTransform;

    public float propulsionForce; 
    
    
    void Start()
    {
        SetInitialReferances();   
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnCannonBall();
            //Debug.Log("Shoot"); <- Not working for some reason?
        }
    }

    //Adjust Transform point as needed
    void SpawnCannonBall()
    {
        GameObject CannonBall = (GameObject) Instantiate(CannonBallPrefab, myTransform.transform.TransformPoint(0, 0, 2f), myTransform.rotation);
        CannonBall.GetComponent<Rigidbody>().AddForce(myTransform.forward * propulsionForce, ForceMode.Impulse);
        Destroy(CannonBall, 3);
    }

    void SetInitialReferances()
    {
        myTransform = transform;
    }
}
