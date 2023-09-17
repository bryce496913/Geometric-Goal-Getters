using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    //references
    public Text playerEndScoreText;
    public Text AIEndScoreText;

    public Goal goalScriptAI;
    public Goal goalScriptPlayer;

    public Timer timerScript;

    public Transform playerRobot;
    public Transform AIRobot;
    public Transform ball;

    public Vector3 playerInitialPosition;
    public Vector3 AIInitialPosition;
    public Vector3 ballInitialPosition;

    public AudioSource whistleSound;

    public AudioSource stadiumSound;

    private void Start()
    {
        playerEndScoreText.text = "0";
        AIEndScoreText.text = "0";

        // Play Whistle sound
	      whistleSound.Play();
    }

    public void UpdateScores(int playerScore, int AIScore)
    {
        playerEndScoreText.text = playerScore.ToString();
        AIEndScoreText.text = AIScore.ToString();
    }

    public void NewGame()
    {
        // Hide the EndGame UI canvas
        gameObject.SetActive(false);

        // Reset Everything
        goalScriptAI.playerScore = 0;
        goalScriptAI.AIScore = 0;
        goalScriptAI.playerScoreText.text = "0";
        goalScriptAI.AIScoreText.text = "0";

        timerScript.ResetTimer();

        // Reset positions of the player robot, AI robot, and ball
        playerRobot.position = playerInitialPosition;
        AIRobot.position = AIInitialPosition;
        ball.position = ballInitialPosition;

        playerRobot.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        AIRobot.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

	whistleSound.Play();

	//Play background sound
	stadiumSound.Play();
    }

    public void ExitGame()
    {
        // Close the application
        Application.Quit();
    }
}
