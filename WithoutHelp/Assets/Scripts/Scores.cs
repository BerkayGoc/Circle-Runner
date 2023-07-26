using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int JumpCount;

    public Text text;

    private void Start()
    {
        JumpCount = 0;
    }

    private void Update()
    {
        text.text = JumpCount.ToString();
    }
}
