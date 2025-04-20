using UnityEngine;
using UnityEngine.UIElements;

public class OpeningUIController : MonoBehaviour
{
    private VisualElement settingsPanel;

    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        var startButton = root.Q<Button>("StartButton");
        var settingsButton = root.Q<Button>("SettingsButton");
        var closeButton = root.Q<Button>("CloseSettingsButton");

        settingsPanel = root.Q<VisualElement>("SettingsPanel");

        settingsButton.clicked += () => {
            settingsPanel.style.display = DisplayStyle.Flex;
        };

        closeButton.clicked += () => {
            settingsPanel.style.display = DisplayStyle.None;
        };

        startButton.clicked += () => {
            Debug.Log("はじめるボタンが押された！");
            // あとで名前入力シーンに移動
        };
    }
}
