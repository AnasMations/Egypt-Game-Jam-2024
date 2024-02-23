using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float countdownTime = 60f; // 1 minute
    public UnityEvent onTimerEnd;

    private float currentTime;

    private void Start()
    {
        currentTime = countdownTime;
    }

    private void Update()
    {
        // Update the timer
        currentTime -= Time.deltaTime;

        // Display the timer in minutes and seconds format
        DisplayTime(currentTime);

        // Check if the countdown has reached zero
        if (currentTime <= 0f)
        {
            onTimerEnd?.Invoke();
            // Perform actions when the countdown reaches zero (e.g., end game, trigger an event)
            Debug.Log("Time's up!");
            currentTime = 0f; // Optional: Set the timer to zero to prevent negative values
        }
    }

    private void DisplayTime(float time)
    {
        // Calculate minutes and seconds
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        // Update the UI text with the formatted time
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
