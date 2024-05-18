using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger2 : MonoBehaviour
{
    void Update()
    {
        // X tuþuna basýldýðýný kontrol et
        if (Input.GetKeyDown(KeyCode.Y))
        {
            // Aktif sahnenin adýný al
            string currentSceneName = SceneManager.GetActiveScene().name;

            Debug.Log(currentSceneName);
            // Eðer sahne 2'de isek, sahne 3'ye geç
            if (currentSceneName == "harita3")
            {
                SceneManager.LoadScene("harita4");
                Debug.Log("Harita 4'e gecildi");
            }
            else
            {
                Debug.Log("Harita 3'te degilsin");
            }
        }
    }
}
