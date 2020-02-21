using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completedLevelUI;

    // Cuando el jugador llega al final del nivel ("colisiona con el cubo END") se dispara
    // el evento de su script, el cual llama a este metodo del manager para mostrar el panel de nivel completado
    public void LevelCompleted()
    {
        completedLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
        
    }

    // Obtiene la escena actual y la reinicia
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
