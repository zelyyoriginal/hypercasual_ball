using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenReloader : MonoBehaviour
{
   


   public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
