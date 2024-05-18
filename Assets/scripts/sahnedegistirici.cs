using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    void Update()
    {
        // X tuþuna basýldýðýný kontrol et
        if (Input.GetKeyDown(KeyCode.X))
        {
            // Aktif sahnenin adýný al
            string currentSceneName = SceneManager.GetActiveScene().name;

            // Eðer sahne 1'de isek, sahne 2'ye geç
            if (currentSceneName == "sahne1")
            {
                SceneManager.LoadScene("sahne2");
            }
        }
    }
}
