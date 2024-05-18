using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneButton : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }
    // Bu fonksiyon buton t�kland���nda �a�r�lacak
    public void OnButtonClick()
    {
        // Bir sonraki sahneye ge�mek i�in sahne y�kleme
        // Mevcut sahnenin bir sonrakini y�klemek i�in
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
