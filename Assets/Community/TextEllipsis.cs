using UnityEngine;
using TMPro;

public class TextEllipsis : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public int maxCharacters = 10; // 최대 표시할 글자 수

    void Start()
    {
        string originalText = textMeshPro.text;
        if (originalText.Length > maxCharacters)
        {
            string newText = originalText.Substring(0, maxCharacters - 3) + "...";
            textMeshPro.text = newText;
        }
    }
}
