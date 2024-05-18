using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AcceptButton : MonoBehaviour
{
    public Button acceptButton;

    void Start()
    {
        // Accept butonuna tıklama olayını bağla
        if (acceptButton != null)
        {
            acceptButton.onClick.AddListener(OnAcceptButtonClick);
        }
    }

    public void OnAcceptButtonClick()
    {
        // Bir sonraki sahneye geç
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
