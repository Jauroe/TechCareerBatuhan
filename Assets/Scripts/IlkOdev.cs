using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class IlkOdev : MonoBehaviour
{
    public int ilkDegisken = 10;
    public float ikinciDegisken = 3f;
    public string ucuncuDegisken = "Batuhan";
    
    public int karakterSayisi = 7;
    
    void Start()
    {
        Debug.Log(canMiktari());
        market();
        karakterEkleme();
    }

    string canMiktari()
    {
        if (ilkDegisken > 80)
        {
            return "Canınız yeterli!";
        } 
        else if (ilkDegisken > 50)
        {
            return "Can iksiri almak isteyebilirsiniz.";
        } 
        else
        {
            return "Can iksirine ihtiyacınız var.";
        }
    }
    
    void market()
    {
        switch (ikinciDegisken)
        {
            case 1f:
                Debug.Log("Sadece 1 ürün alınabilir.");
                break;
            case 2f:
                Debug.Log("2 ürün alınabilir.");
                break;
            case 3f:
                Debug.Log( ikinciDegisken + " ürün alınabilir.");
                break;
            default:
                Debug.Log("Ürünler satın alınamıyor.");
                break;
        }
    }

    void karakterEkleme()
    {
        int i = 0;
        
        while (karakterSayisi >= 1 && karakterSayisi <= 20)
        {
            ucuncuDegisken += ucuncuDegisken[i];
            i++;
            karakterSayisi--;
        }
        Debug.Log(ucuncuDegisken);
    }
}
