using UnityEngine;

public class KarakterSpam : MonoBehaviour
{
    public float hareketHizi = 2f; // Karakterin hareket h�z�
    public float spamSuresi = 5f; // Karakterin spamlanma s�resi
    public float minYukseklik = 1.0f; // Rastgele y konumu i�in minimum y�kseklik
    public float maxYukseklik = 1.25f; // Rastgele y konumu i�in maksimum y�kseklik
    private Vector3 baslangicKonumu; // Karakterin ba�lang�� konumu

    void Start()
    {
        // Karakterin ba�lang�� konumunu kaydet
        baslangicKonumu = transform.position;

        // Karakterin spamlanmas�n� ba�lat
        InvokeRepeating("KarakteriSpamla", spamSuresi, spamSuresi);
    }

    void Update()
    {
        // Karakteri -x y�n�nde hareket ettir
        transform.Translate(Vector3.left * hareketHizi * Time.deltaTime);
    }

    void KarakteriSpamla()
    {
        // Karakterin rastgele y konumunu hesapla
        float rastgeleY = Random.Range(minYukseklik, maxYukseklik);

        // Karakteri ba�lang�� konumuna geri d�nd�r, fakat y konumunu rastgele belirle
        transform.position = new Vector3(baslangicKonumu.x, rastgeleY, baslangicKonumu.z);
    }
}
