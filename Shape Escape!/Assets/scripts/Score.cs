using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour {

    public Transform player;
    public TextMeshProUGUI ScoreText;
    // Update is called once per frame
    void Update() {

        ScoreText.text = ((player.position.z)/10).ToString("0");
        
            
    }
}
