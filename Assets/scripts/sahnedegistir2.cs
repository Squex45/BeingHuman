using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger2 : MonoBehaviour
{
    void Update()
    {
        // X tu�una bas�ld���n� kontrol et
        if (Input.GetKeyDown(KeyCode.Y))
        {
            // Aktif sahnenin ad�n� al
            string currentSceneName = SceneManager.GetActiveScene().name;

            Debug.Log(currentSceneName);
            // E�er sahne 2'de isek, sahne 3'ye ge�
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
