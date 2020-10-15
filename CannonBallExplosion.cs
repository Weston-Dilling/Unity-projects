using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallExplosion : MonoBehaviour
{
    public float blastRadius = 20f;
    public float explosionForce = 100f;

    private Collider[] hitColliders; 

    void OnCollisionEnter(Collision col)
    {
        //Debug.Log(col.contacts[0].point.ToString());
        DoExplosion(col.contacts[0].point);
        Destroy(gameObject);
    }

    void DoExplosion(Vector3 explosionPoint)
    {
        hitColliders = Physics.OverlapSphere(explosionPoint, blastRadius);

        foreach (Collider hitcol in hitColliders)
        {
            //Debug.Log(hitcol.gameObject.name);
            if(hitcol.GetComponent<Rigidbody>() != null)
            {
                hitcol.GetComponent<Rigidbody>().isKinematic = false;
                hitcol.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, explosionPoint, blastRadius, .02f, ForceMode.Impulse);
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
