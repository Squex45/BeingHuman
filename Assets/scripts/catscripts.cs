using UnityEngine;

public class KediFigurHareket : MonoBehaviour
{
    public Animator animator;
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
            animator.enabled = true;
            // Animasyonu devam ettir
            hareket.x = hareketHizi * Time.deltaTime;
            Debug.Log("D tuþuna basýldý, saða hareket ediyor");
            // Saða hareket ettiði için yönünü saða döndür
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            // Animasyonu devam ettir
            hareket.x = hareketHizi * Time.deltaTime;  // Hýz deðeri pozitif
            Debug.Log("A tuþuna basýldý, sola hareket ediyor");
            // Sola hareket ettiði için yönünü sola döndür
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            animator.enabled = true;
        }
        else 
        {
            animator.enabled = false;
            // Animasyonu durdur
            // Hiçbir þey
        }

        // Yukarý hareket
        if (Input.GetKey(KeyCode.W))
        {
            // Animasyonu devam ettir
            hareket.y = hareketHizi * Time.deltaTime;
            Debug.Log("W tuþuna basýldý, yukarý hareket ediyor");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // Animasyonu devam ettir
            hareket.y = -1 * hareketHizi * Time.deltaTime;  // Hýz deðeri pozitif
            Debug.Log("S tuþuna basýldý, aþaðý hareket ediyor");
            // Aþaðý hareket ettiði için yönünü sola döndür
        }
        else
        {
            // Animasyonu durdur
            // Hiçbir þey
        }

        // Kedifigürü hareket ettir
        transform.Translate(hareket, Space.Self);
    }
}