using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    Rigidbody2D rigidbody;
    float force = 5f;
	// Use this for initialization
	void Start () {
        //Add Rigidbody2D in Runtime // 런타임에 리지드 바디를 생성해서 추가한다.
        rigidbody = gameObject.AddComponent<Rigidbody2D>();
        //rigidbody bodyType (Dynamic,kinematic,static)
        rigidbody.bodyType = RigidbodyType2D.Dynamic; // Use Gravity
	}
	
	// Update is called once per frame
	void Update () {
        UseRigidbody();

	}
    void UseRigidbody(){
        // Use Rigidbody // 중력 사용해서 캐릭터 움직이기 

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Add an instant force impulse to the rigidbody //짧은 힘을 가한다.
            rigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            //Add a force to the rigidbody //지속적인 힘을 가함 
            //rigidbody.AddForce(Vector2.up * force, ForceMode2D.Force);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigidbody.velocity = Vector2.zero;
            rigidbody.AddForce(Vector2.right * force, ForceMode2D.Impulse);
            //rigidbody.AddForce(Vector2.right * force, ForceMode2D.Force);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigidbody.velocity = Vector2.zero;
            rigidbody.AddForce(Vector2.left * force, ForceMode2D.Impulse);
            //rigidbody.AddForce(Vector2.left * force, ForceMode2D.Force);
        }
    }

}
