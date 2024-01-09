using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butonlar : MonoBehaviour
{
    public void CikisButonu()
    {
        print("Oyundan ��k�ld�.");
        Application.Quit();
    }
    public void YeniOyun()
    {
        SceneManager.LoadScene(1);
    }
    public void �lkSahne()
    {
        SceneManager.LoadScene(0);
    }
    public void On_Value_Changed(float deger)
    {
        print(deger);
    }
    public void ToggleEnabled(bool TiklandiMi)
    {
        if (TiklandiMi)
        {
            print("Var");
        }
        else
        {
            print("Yok");
        }
    }
    public void OnEndEditText(string metinseldeger)
    {
        print("Metin:" + metinseldeger);
    }
    public void DropdownValue(int sayi)
    {
        if (sayi== 1)
        {
            print("Cinsiyeti kad�n");
        }
        else if (sayi== 2)
        {
            print("Cinsiyeti erkek");
        }
    }
 
}
