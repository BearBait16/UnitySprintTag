using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
   int numKey = 0;
   [SerializeField]
   GameObject enemy;
   [SerializeField]
   GameObject key;
   static Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
      SpawnKey();
    }
    public void SpawnKey()
   {
      if (numKey <= 3)
      {
         if (numKey == 0)
         {
            position = new Vector3(-7.5f, -4f);
            Instantiate(key, position, Quaternion.identity);
         }
         else if (numKey == 1)
         {
            position = new Vector3(10.3f, 3f);
            Instantiate(key, position, Quaternion.identity);
         }
         else if (numKey == 2)
         {
            position = new Vector3(-11.1f, 3.6f);
            Instantiate(key, position, Quaternion.identity);
         }
         else if (numKey == 3)
         {
            playerWins();
         }
         numKey += 1;
         }   
    }

   public void playerWins()
   {
      SceneManager.LoadScene("GameWinScene");
   }

   public void playerDies()
   {
      SceneManager.LoadScene("RestartScene");
   }
}
