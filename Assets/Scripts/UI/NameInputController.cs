using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class NameInputController : MonoBehaviour
{
    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        var playerInput = root.Q<TextField>("PlayerNameInput");
        var aiInput = root.Q<TextField>("AINameInput");
        var confirmButton = root.Q<Button>("ConfirmButton");

        confirmButton.clicked += () => {
            string playerName = playerInput.text;
            string aiName = aiInput.text;

            PlayerPrefs.SetString("PlayerName", playerName);
            PlayerPrefs.SetString("AIName", aiName);
            PlayerPrefs.Save();

            Debug.Log($"名前保存：{playerName}, {aiName}");

            SceneManager.LoadScene("Personality"); // 次のシーン名（仮）
        };
    }
}
