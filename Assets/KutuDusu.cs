using UnityEngine;

public class KutuDusu : MonoBehaviour
{
    // Butonu buraya sürükleyeceğiz
    public GameObject gecisButtonu;

    // Çarpışma olduğunda çalışır
    private void OnCollisionEnter(Collision collision)
    {
        // Eğer çarptığımız şeyin etiketi "Zemin" ise
        if (collision.gameObject.CompareTag("Zemin"))
        {
            Debug.Log("Kutu yere düştü! Bölüm geçildi.");

            // Butonu görünür yap
            // (Eğer buton zaten açıksa hata vermez, tekrar açmaya çalışır sadece)
            if (gecisButtonu != null)
            {
                gecisButtonu.SetActive(true);
            }
        }
    }
}