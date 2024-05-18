using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneButton : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }
    // Bu fonksiyon buton týklandýðýnda çaðrýlacak
    public void OnButtonClick()
    {
        // Bir sonraki sahneye geçmek için sahne yükleme
        // Mevcut sahnenin bir sonrakini yüklemek için
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
