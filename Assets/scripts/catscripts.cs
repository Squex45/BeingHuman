using UnityEngine;

public class KediFigurHareket : MonoBehaviour
{
    public Animator animator;
    public float hareketHizi = 2f; // Karakterin hareket h�z�, daha yava�

    void Update()
    {
        HareketEt();
    }

    void HareketEt()
    {
        Vector3 hareket = Vector3.zero;

        // Sa� ve sol hareket
        if (Input.GetKey(KeyCode.D))
        {
            animator.enabled = true;
            // Animasyonu devam ettir
            hareket.x = hareketHizi * Time.deltaTime;
            Debug.Log("D tu�una bas�ld�, sa�a hareket ediyor");
            // Sa�a hareket etti�i i�in y�n�n� sa�a d�nd�r
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            // Animasyonu devam ettir
            hareket.x = hareketHizi * Time.deltaTime;  // H�z de�eri pozitif
            Debug.Log("A tu�una bas�ld�, sola hareket ediyor");
            // Sola hareket etti�i i�in y�n�n� sola d�nd�r
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            animator.enabled = true;
        }
        else 
        {
            animator.enabled = false;
            // Animasyonu durdur
            // Hi�bir �ey
        }

        // Yukar� hareket
        if (Input.GetKey(KeyCode.W))
        {
            // Animasyonu devam ettir
            hareket.y = hareketHizi * Time.deltaTime;
            Debug.Log("W tu�una bas�ld�, yukar� hareket ediyor");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // Animasyonu devam ettir
            hareket.y = -1 * hareketHizi * Time.deltaTime;  // H�z de�eri pozitif
            Debug.Log("S tu�una bas�ld�, a�a�� hareket ediyor");
            // A�a�� hareket etti�i i�in y�n�n� sola d�nd�r
        }
        else
        {
            // Animasyonu durdur
            // Hi�bir �ey
        }

        // Kedifig�r� hareket ettir
        transform.Translate(hareket, Space.Self);
    }
}