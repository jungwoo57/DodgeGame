using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    float hAxis;
    float vAxis;
    public float hp;

    public float speed;
    Vector3 moveVec;
    private void Update()
    {
        GetInput();
        Move();
    }

    void GetInput()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
    }

    void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        transform.position += moveVec * speed * Time.deltaTime;
    }

    void OnDie()
    {
        gameObject.SetActive(false); 
    }

    public void OnDamage(int dmg) 
    {
        hp -= dmg;
        if (hp <= 0){
            OnDie();
        }
    }
}
