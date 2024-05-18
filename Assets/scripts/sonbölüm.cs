using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour
{
    public Transform target;  // Hedef noktası
    private GameObject objectToMove;  // Taşınacak nesne
    private bool isHoldingObject = false;  // Nesne tutuluyor mu?
    public GameObject winText;  // Kazandınız mesajı için UI Text

    void Start()
    {
        // Başlangıçta kazandınız mesajını gizle
        winText.gameObject.SetActive(false);
    }

    void Update()
    {
        // Mouse sol tıklamasıyla nesneyi tutmayı veya bırakmayı kontrol et
        if (Input.GetMouseButtonDown(0))
        {
            if (objectToMove != null && !isHoldingObject)
            {
                // Nesneyi tut
                isHoldingObject = true;
                objectToMove.GetComponent<Rigidbody2D>().isKinematic = true;  // Nesnenin fiziksel etkilerini devre dışı bırak
                objectToMove.transform.SetParent(this.transform);  // Nesneyi oyuncuya bağla
            }
            else if (isHoldingObject)
            {
                // Nesneyi bırak
                isHoldingObject = false;
                objectToMove.GetComponent<Rigidbody2D>().isKinematic = false;  // Nesnenin fiziksel etkilerini geri getir
                objectToMove.transform.SetParent(null);  // Nesneyi oyuncudan ayır
            }
        }

        // Nesne tutuluyorsa hedefe ulaşıp ulaşmadığını kontrol et
        if (isHoldingObject && Vector3.Distance(objectToMove.transform.position, target.position) < 0.5f)
        {
            // Nesne hedefe ulaştı
            isHoldingObject = false;
            objectToMove.GetComponent<Rigidbody2D>().isKinematic = false;  // Nesnenin fiziksel etkilerini geri getir
            objectToMove.transform.SetParent(null);  // Nesneyi oyuncudan ayır
            ShowWinMessage();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Oyuncu bir nesneye dokunduğunda
        if (other.gameObject.CompareTag("MovableObject"))
        {
            objectToMove = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Oyuncu nesneden uzaklaştığında
        if (other.gameObject.CompareTag("MovableObject") && !isHoldingObject)
        {
            objectToMove = null;
        }
    }

    private void ShowWinMessage()
    {
        winText.gameObject.SetActive(true);
    }
}
