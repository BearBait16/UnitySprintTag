using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
   public void OnButtonPress()
   {
      Debug.Log("Button Pressed");
      SceneManager.LoadScene("SampleScene");
   }
}