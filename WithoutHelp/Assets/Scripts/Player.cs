using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpForce = 4f;
    public Rigidbody2D rb;

    private bool isJumping;
    private bool isDead = false;

    public RestartButton restartButton;

    void Update()
    {
        if (!isDead && isJumping)
        {
            if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.up * jumpForce;
                Score.JumpCount++;

                isJumping = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Triangle")
        {
            Debug.Log("GameOver");
            Die();
            restartButton.ShowRestartButton();
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Floor")
        {
            isJumping = true;
        }
    }

    public void Die()
    {
        isDead = true;
        Time.timeScale = 0f;
    }

    public void Revive()
    {
        isDead = false;
        Time.timeScale = 1f;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
