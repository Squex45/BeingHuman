using UnityEngine;

public class KediFigurHareket : MonoBehaviour
{
    public float hareketHizi = 2f; // Karakterin hareket hýzý, daha yavaþ

    void Update()
    {
        HareketEt();
    }

    void HareketEt()
    {
        Vector3 hareket = Vector3.zero;

        // Sað ve sol hareket
        if (Input.GetKey(KeyCode.D))
        {
            hareket.x = hareketHizi * Time.deltaTime;
            Debug.Log("D tuþuna basýldý, saða hareket ediyor");
            // Saða hareket ettiði için yönünü saða döndür
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            hareket.x = hareketHizi * Time.deltaTime;  // Hýz deðeri pozitif
            Debug.Log("A tuþuna basýldý, sola hareket ediyor");
            // Sola hareket ettiði için yönünü sola döndür
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        // Yukarý hareket
        if (Input.GetKey(KeyCode.W))
        {
            hareket.y = hareketHizi * Time.deltaTime;
            Debug.Log("W tuþuna basýldý, yukarý hareket ediyor");
        }

        // Kedifigürü hareket ettir
        transform.Translate(hareket, Space.Self);
    }
}