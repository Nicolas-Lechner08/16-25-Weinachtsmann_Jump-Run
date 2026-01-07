using UnityEngine;
using UnityEngine.SceneManagement;
public class Button_Script : MonoBehaviour
{
      public string Scene = "start_scene";
      public void switch_scene(){
      SceneManager.LoadScene(Scene);
      }
      public void quit(){
            Application.Quit();
      }
}
