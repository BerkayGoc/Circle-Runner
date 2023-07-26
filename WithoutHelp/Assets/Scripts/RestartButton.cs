using UnityEngine;

public class RestartButton : MonoBehaviour
{
    public GameObject restartButton;

    private void Start()
    {
        restartButton.SetActive(false);
    }

    public void ShowRestartButton()
    {
        restartButton.SetActive(true);
    }

    public void RestartScene()
    {
        restartButton.SetActive(false);
        Player playerController = FindObjectOfType<Player>();
        playerController.RestartLevel();
    }
}
