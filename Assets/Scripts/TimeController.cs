using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public float timeLimit = 60f; // Time limit in seconds
    private float timer; // Current time remaining

    public Text timerText; // Reference to the UI text element to display the timer

    // Start is called before the first frame update
    void Start()
    {
        timer = timeLimit; // Initialize timer to time limit
    }

    // Update is called once per frame
    void Update()
    {
        // Update the timer countdown
        timer -= Time.deltaTime;

        // Update the timer display
        UpdateTimerDisplay();

        // Check if time runs out
        if (timer <= 0f)
        {
            // Handle time up condition (e.g., game over)
            HandleTimeUp();
        }
    }

    void UpdateTimerDisplay()
    {
        // Check if timerText is not null before updating
        if (timerText != null)
        {
            // Format the time remaining as minutes and seconds
            int minutes = Mathf.FloorToInt(timer / 60f);
            int seconds = Mathf.FloorToInt(timer % 60f);

            // Update the UI text to display the formatted time
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            Debug.LogError("Timer text reference is not set!");
        }
    }

    void HandleTimeUp()
    {
        // Handle what happens when time runs out (e.g., game over)
        Debug.Log("Time's up!");
    }
}
