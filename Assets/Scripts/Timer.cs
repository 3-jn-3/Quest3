using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.Rendering.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] public float countdown = 100;
    [SerializeField] Transform uiCanvas;

    public GameObject YouWin;

    public static bool hasEnded = false;

    void Update()
    {
        if (!hasEnded)
        {
            if (countdown > 0)
            {
                countdown -= Time.deltaTime;
                // (int) converts 99.98 to 99
                timerText.text = ((int)countdown).ToString();
            }
            else
            {
                countdown = 0;
                timerText.text = "0";
                timerEnded();
            }
        }

    }

    void timerEnded()
    {
        hasEnded = true;
        Instantiate(YouWin, uiCanvas);
    }


}