using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    //references
    public Text timerText;
    public int initialTime = 60;
    public int currentTime;

    public Canvas endGameCanvas;

    void Start()
    {
        endGameCanvas.gameObject.SetActive(false);
        currentTime = initialTime;
        UpdateTimerUI();
        InvokeRepeating("UpdateTimer", 1.0f, 1.0f);
    }

    void UpdateTimer()
    {
        currentTime--;
        UpdateTimerUI();

        if (currentTime <= 0)
        {
            CancelInvoke("UpdateTimer");

            // Show the EndGame canvas when time is up
            endGameCanvas.gameObject.SetActive(true);
        }
    }

    void UpdateTimerUI()
    {
        timerText.text = currentTime.ToString();
    }

    // Public method to reset the timer
    public void ResetTimer()
    {
        currentTime = initialTime;
        UpdateTimerUI();
        Start(); // Call Start() again to restart the countdown
    }

}
