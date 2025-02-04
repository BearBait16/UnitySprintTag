using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Player : MonoBehaviour
{
   float speed = 5f;
   
   // Start is called before the first frame update
   void Start()
    {
      transform.position = new Vector3(5.5f, 0f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
      Movement();
    }

   void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, verticalInput).normalized * Time.deltaTime * speed;
        transform.position += movement;
        Walls();
    }

    void Walls()
    {
      if (transform.position.y < -4.4f)
      {
         transform.position = new Vector3(transform.position.x, -4.4f);
      }
      if (transform.position.y > 4.4f)
      {
         transform.position = new Vector3(transform.position.x, 4.4f);
      }
      if (transform.position.x < -12.0f)
      {
         transform.position = new Vector3(-12.0f, transform.position.y);
      }
      if (transform.position.x > 12.0f)
      {
         transform.position = new Vector3(12.0f, transform.position.y);
      }
    }
}
