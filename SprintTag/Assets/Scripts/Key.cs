using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
   GameObject spawnManager;
   void Start()
   {
      spawnManager = GameObject.Find("SpawnManager");
   }
   // Start is called before the first frame update
   void OnCollisionEnter2D(Collision2D collision)
   {
      GameObject touchOrigin = collision.gameObject;
      if (touchOrigin.tag == "Player")
      {
         spawnManager.GetComponent<SpawnManager>().SpawnKey();
         Destroy(this.gameObject);
      }
   }
}
