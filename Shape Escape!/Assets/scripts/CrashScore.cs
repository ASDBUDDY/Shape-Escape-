using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CrashScore : MonoBehaviour {

    public TextMeshProUGUI CrashScoreText;
    public bool flag = false;

    public void Crash (float yes) {
        if (flag == false)
        {
            flag = true;
            yes = yes / 10;
            CrashScoreText.text = yes.ToString("0");
        }
        }
}
