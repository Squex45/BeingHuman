using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger3 : MonoBehaviour
{
    void Update()
    {
        // X tu�una bas�ld���n� kontrol et
        if (Input.GetKeyDown(KeyCode.T))
        {
            // Aktif sahnenin ad�n� al
            string currentSceneName = SceneManager.GetActiveScene().name;

            Debug.Log(currentSceneName);
            // E�er sahne 5'de isek, sahne 6'ye ge�
            if (currentSceneName == "harita5")
            {
                SceneManager.LoadScene("harita6");
                Debug.Log("Harita 6'e gecildi");
            }
            else
            {
                Debug.Log("Harita 5'te degilsin");
            }
        }
    }
}