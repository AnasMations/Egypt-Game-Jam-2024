using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class BalanceGameManager : MonoBehaviour
{
    public Slider peaceMeterSlider;
    public UnityEvent onGameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        peaceMeterSlider.value = GLOBALSBalance.PeaceMeter/100f;
        if(GLOBALSBalance.PeaceMeter <= 0)
        {
            // Game over
            onGameOver?.Invoke();
            Debug.Log("Game Over");
        }
    }

    public void RestartGame()
    {
        GLOBALSBalance.PeaceMeter = 100;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

public static class GLOBALSBalance
{
    public static int PeaceMeter = 100;
}
