using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int score = 0; // Player's score
    public Text scoreText; // UI Text component to display the score
    public GameObject gameOverScreen; // Panel to show when the game is over
    public AudioClip flapSound;
    public AudioClip scoreSound;
    public AudioClip gameOverSound; // Sound to play when the game is over
    public AudioSource audioSource;
        void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    [ContextMenu("Add Score")]
    public void AddScore(int scoreIncrement)
    {
        score += scoreIncrement; // Increment the score by the value passed

        audioSource.PlayOneShot(scoreSound); // Play the score sound effect
        scoreText.text = score.ToString(); // Update the score text in the UI
    }

    public void GameOver()
    {
        audioSource.PlayOneShot(gameOverSound); // Play the game over sound effect
        gameOverScreen.SetActive(true); // Show the game over screen
        Time.timeScale = 0; // Pause the game
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
        Time.timeScale = 1; // Resume the game
        
    }
}
