using UnityEngine;
using UnityEngine.SceneManagement; // Sahne yönetimi için bu kütüphane þart!

public class LevelGecis : MonoBehaviour
{
    // Bu fonksiyonu butona baðlayacaðýz
    public void SonrakiLevel()
    {
        // Mevcut sahnenin numarasýný al ve 1 ekle (Sýradaki sahne)
        int aktifSahne = SceneManager.GetActiveScene().buildIndex;

        // Bir sonraki sahneyi yükle
        SceneManager.LoadScene(aktifSahne + 1);
    }

    // Oyunu kapatmak istersen bunu da kullanabilirsin
    public void OyundanCikis()
    {
        Application.Quit();
        Debug.Log("Oyundan çýkýldý!");
    }
}