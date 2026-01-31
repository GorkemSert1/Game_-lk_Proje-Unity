using UnityEngine;

using UnityEngine;
using UnityEngine.SceneManagement; // 1. BU SATIR ÇOK ÖNEMLÝ! Sahne iþlemleri için þart.

public class OyunKontrol : MonoBehaviour
{
    void Update()
    {
        // 'R' tuþuna basýnca sahneyi yenile
        if (Input.GetKeyDown(KeyCode.R))
        {
            SahneyiYenile();
        }

        // 'ESC' (Escape) tuþuna basýnca oyundan çýk
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OyundanCik();
        }
    }

    void SahneyiYenile()
    {
        // Þu an açýk olan sahnenin ismini bulur ve aynýsýný tekrar yükler
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OyundanCik()
    {
        Debug.Log("Oyundan çýkýlýyor..."); // Editörde çalýþtýðýný anlamak için not
        Application.Quit();
    }
}