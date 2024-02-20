using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerMovement : MonoBehaviour
{
    public float speed;
    private float Move;
    private Rigidbody rb;
    [SerializeField]
    public GameObject GameOverScreen;

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
            Time.timeScale = 0f;
            GameOverScreen.SetActive(true);
        }
    }

}
