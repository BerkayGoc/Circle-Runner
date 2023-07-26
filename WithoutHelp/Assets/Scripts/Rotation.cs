using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 100f;
    private bool isGameRunning = true;

    // Update is called once per frame
    void Update()
    {
        if (isGameRunning)
            transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }

    public void StopGame()
    {
        isGameRunning = false;
    }
}
