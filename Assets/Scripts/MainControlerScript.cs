using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControlerScript : MonoBehaviour
{
    public GameObject[] objetos;
    int currentIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            if (currentIndex >= objetos.Length)
            {
                currentIndex = 0;
            }
            DeactivateAll();
            ActivaByIndex(currentIndex);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if (currentIndex >= objetos.Length)
            {
                currentIndex = 0;
            }
            DeactivateAll();
            ActivaByIndex(currentIndex);
        }
    }
    void DeactivateAll()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }
    }

    void ActivaByIndex(int index)
    {
        objetos[index].SetActive(true);
    }
}
