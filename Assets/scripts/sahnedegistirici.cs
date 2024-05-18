using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    void Update()
    {
        // X tu�una bas�ld���n� kontrol et
        if (Input.GetKeyDown(KeyCode.X))
        {
            // Aktif sahnenin ad�n� al
            string currentSceneName = SceneManager.GetActiveScene().name;

            // E�er sahne 1'de isek, sahne 2'ye ge�
            if (currentSceneName == "sahne1")
            {
                SceneManager.LoadScene("sahne2");
            }
        }
    }
}
