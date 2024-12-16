using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textLabel;

    private float score = 0f;

    private void FixedUpdate() {
        score++;
        textLabel.text = (score/10).ToString();
    }
}
