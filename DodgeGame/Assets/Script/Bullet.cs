using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int dmg;
    public float speed;
    Rigidbody bulletRigid;

    private void Start()
    {
        bulletRigid =GetComponent<Rigidbody>();
        bulletRigid.velocity = transform.forward * speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") {
            Player player = other.GetComponent<Player>();
            player.OnDamage(dmg);
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "Wall"){
            Destroy(gameObject);
        }
    }
} 
