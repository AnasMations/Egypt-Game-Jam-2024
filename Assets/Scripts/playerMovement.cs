using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class playerMovement : MonoBehaviour
{
    public float speed;
    private float Move;
    private Rigidbody rb;
    [SerializeField]
    public Slider slider;
    public UnityEvent OnLose;

    // Start is called before the first frame update
    void Start()
    {
    Time.timeScale = 1f;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");   
        rb.velocity = new Vector3(Move * speed, rb.velocity.y);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("walker"))
        {
            slider.value = slider.value - 0.34f;
            if (slider.value <= 0)
            {
                OnLose?.Invoke();
                Time.timeScale = 0f;
            }
        }
    }

}
