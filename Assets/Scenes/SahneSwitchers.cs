using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        // Sahne yüklendiðinde playerPosition'ý geri yükle
        if (GameManager.Instance != null && SceneManager.GetActiveScene().name == "harita1" && GameManager.Instance.usePlayerPosition)
        {
            player.transform.position = GameManager.Instance.playerPosition;
        }
    }

    void Update()
    {
        // Eðer X tuþuna basýldýysa
        if (Input.GetKeyDown(KeyCode.X))
        {
            // Þu anki sahneyi al
            string currentSceneName = SceneManager.GetActiveScene().name;

            if (currentSceneName == "harita2")
            {
                Debug.Log("X tuþuna basýldý, harita2'deyken harita1 sahnesine geçiþ yapýlýyor...");
                // Eðer þu anki sahne "harita2" ise "harita1" sahnesine geç
                SceneManager.LoadScene("harita1");
            }
            else
            {
                // Karakterin pozisyonunu kaydet
                GameManager.Instance.playerPosition = player.transform.position;
                GameManager.Instance.usePlayerPosition = true;
                Debug.Log("X tuþuna basýldý, harita2 sahnesine geçiþ yapýlýyor...");
                // Diðer durumlarda "harita2" sahnesine geç
                SceneManager.LoadScene("harita2");
            }
        }
    }
}
