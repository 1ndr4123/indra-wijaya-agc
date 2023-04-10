using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier = 2f; // deklarasi variabel multiplier dan menginisialisasi nilainya

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier; // menggunakan variabel multiplier yang sudah dideklarasikan dan diinisialisasi
        }
    }
}
