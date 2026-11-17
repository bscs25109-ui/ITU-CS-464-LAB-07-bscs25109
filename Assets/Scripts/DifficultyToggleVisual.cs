
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyToggleVisual : MonoBehaviour
{
    [SerializeField] private Toggle difficultyToggle;
    [SerializeField] private TMP_Text label;

    [SerializeField]
    private Color selectedTextColor =
        new Color32(24, 43, 54, 255);

    [SerializeField]
    private Color unselectedTextColor =
        new Color32(243, 240, 232, 255);

    private void Awake()
    {
        if (difficultyToggle == null)
            difficultyToggle = GetComponent<Toggle>();

        Refresh(difficultyToggle != null &&
                difficultyToggle.isOn);
    }

    public void OnChanged(bool isOn)
    {
        Refresh(isOn);
    }

    private void Refresh(bool isOn)
    {
        if (label == null) return;

        label.color = isOn
            ? selectedTextColor
            : unselectedTextColor;
    }
}
