using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        // Sahne y�klendi�inde playerPosition'� geri y�kle
        if (GameManager.Instance != null && SceneManager.GetActiveScene().name == "harita1" && GameManager.Instance.usePlayerPosition)
        {
            player.transform.position = GameManager.Instance.playerPosition;
        }
    }

    void Update()
    {
        // E�er X tu�una bas�ld�ysa
        if (Input.GetKeyDown(KeyCode.X))
        {
            // �u anki sahneyi al
            string currentSceneName = SceneManager.GetActiveScene().name;

            if (currentSceneName == "harita2")
            {
                Debug.Log("X tu�una bas�ld�, harita2'deyken harita1 sahnesine ge�i� yap�l�yor...");
                // E�er �u anki sahne "harita2" ise "harita1" sahnesine ge�
                SceneManager.LoadScene("harita1");
            }
            else
            {
                // Karakterin pozisyonunu kaydet
                GameManager.Instance.playerPosition = player.transform.position;
                GameManager.Instance.usePlayerPosition = true;
                Debug.Log("X tu�una bas�ld�, harita2 sahnesine ge�i� yap�l�yor...");
                // Di�er durumlarda "harita2" sahnesine ge�
                SceneManager.LoadScene("harita2");
            }
        }
    }
}
