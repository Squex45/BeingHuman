using UnityEngine;

public class KarakterSpam : MonoBehaviour
{
    public float hareketHizi = 2f; // Karakterin hareket hýzý
    public float spamSuresi = 5f; // Karakterin spamlanma süresi
    public float minYukseklik = 1.0f; // Rastgele y konumu için minimum yükseklik
    public float maxYukseklik = 1.25f; // Rastgele y konumu için maksimum yükseklik
    private Vector3 baslangicKonumu; // Karakterin baþlangýç konumu

    void Start()
    {
        // Karakterin baþlangýç konumunu kaydet
        baslangicKonumu = transform.position;

        // Karakterin spamlanmasýný baþlat
        InvokeRepeating("KarakteriSpamla", spamSuresi, spamSuresi);
    }

    void Update()
    {
        // Karakteri -x yönünde hareket ettir
        transform.Translate(Vector3.left * hareketHizi * Time.deltaTime);
    }

    void KarakteriSpamla()
    {
        // Karakterin rastgele y konumunu hesapla
        float rastgeleY = Random.Range(minYukseklik, maxYukseklik);

        // Karakteri baþlangýç konumuna geri döndür, fakat y konumunu rastgele belirle
        transform.position = new Vector3(baslangicKonumu.x, rastgeleY, baslangicKonumu.z);
    }
}
