using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBox : MonoBehaviour {


    public Rigidbody2D rb2D;
    Vector3 pos;
    void Start()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
        rb2D.bodyType = RigidbodyType2D.Kinematic;
    }
    void FixedUpdate()
    {
        pos = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        Ray2D ray =  
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 1000f);
        Debug.DrawRay(transform.localPosition, hit.transform.position, Color.red);
        //if (hit.collider != null)
        //{
        //    Debug.Log(hit.collider.gameObject.name);
        //    Debug.DrawRay(transform.position, hit.transform.position, Color.red);
        //}

    }
}
