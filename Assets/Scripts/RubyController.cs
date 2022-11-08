using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class RubyController : MonoBehaviour
//{
    // Start is called before the first frame update
    //void Start()
    //{
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;
    //}

    // Update is called once per frame
    //void Update()
    //{
        //Vector2 position = transform.position;
        //position.x = position.x + 0.025f;
        //transform.position = position;
        
        //Debug.Log(horizontal);
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");

        //Vector2 position = transform.position;
        //position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        //position.y = position.y + 3.0f * vertical * Time.deltaTime;
        //transform.position = position;
    //}
//}
public class RubyController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }
}