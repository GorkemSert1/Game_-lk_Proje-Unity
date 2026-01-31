using UnityEngine;

public class Firlatici : MonoBehaviour
{
    public float guc = -100f; // Fýrlatma gücü 
    public Rigidbody topRB;   // Hangi Rigidbody'i fýrlatacaðýz? 

    void Update()
    {
        // Boþluk (Space) tuþuna basýnca çalýþýr 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Topa ileriye (Forward) doðru ani bir kuvvet (Impulse) uygula 
            topRB.AddForce(new Vector3(-10,0,0) * guc, ForceMode.Impulse);
        }
    }
}
