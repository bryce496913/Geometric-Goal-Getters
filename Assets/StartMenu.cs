using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    //references
    public Canvas startMenuCanvas;

    public Canvas gameplayCanvas;

    public AudioSource whistleSound;

    public AudioSource stadiumSound;

    void Start()
    {
        // Initially, disable the gameplay Canvas
        gameplayCanvas.enabled = false;
    }

    // Method called when the user clicks the start button
    public void StartGame()
    {
        // Disable the start menu Canvas
        startMenuCanvas.enabled = false;

        // Enable the gameplay Canvas
        gameplayCanvas.enabled = true;

        // Play the whistle sound
        whistleSound.Play();

	      //Play background sound
	      stadiumSound.Play();

    }

    // Method called when the user clicks the exit button
    public void ExitGame()
    {
        Application.Quit();
    }
}
