using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
   
  public PauseMenu pauseMenu;

  void Start () {

  }


  void Update () {


  {
    if (Input.GetKeyDown(KeyCode.Escape))
        pauseMenu.gameObject.SetActive(!pauseMenu.gameObject.activeSelf);
  }

 }
    
}
