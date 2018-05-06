using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

	public void Quit()
    {
        Debug.Log("QUIT!");
        SceneManager.LoadScene(0);      //restart game
        //Application.Quit();
    }
}
