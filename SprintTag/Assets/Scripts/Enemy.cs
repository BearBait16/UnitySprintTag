using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   GameObject spawnManager;
   private Transform target;
   private float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
      transform.position = new Vector3(0, -3f, transform.position.z);
      setTarget();
      spawnManager = GameObject.Find("SpawnManager");

   }

   // Update is called once per frame
   void Update()
    {
      Follow();
    }

    void Follow()
    {
      if (target != null)
      {
         transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
      }
    }
   void setTarget()
   {
      GameObject player = GameObject.FindGameObjectWithTag("Player");
      if (player == null)
      {
         Debug.Log("AHHHHHHHHHHH");
      }
      else
      {
         target = player.transform;
      }
   }

   private void OnCollisionEnter2D(Collision2D collision)
   {
      GameObject touchOrigin = collision.gameObject;
      if (touchOrigin.tag == "Player")
      {
         Destroy(touchOrigin);
         spawnManager.GetComponent<SpawnManager>().playerDies();
      }
   }
}
