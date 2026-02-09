using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("nemu");
    }
}