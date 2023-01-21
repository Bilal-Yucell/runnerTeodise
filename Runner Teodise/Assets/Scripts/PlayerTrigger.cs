using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;
using UnityEngine.UI;
using UnityEngine.TextCore;
using UnityEngine;


public class PlayerTrigger : MonoBehaviour
{
    public int currentMoney = 140000;
    public int currentOy = 35;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI oyText;
    // public AudioClip smallVoice;
    AudioSource aSource;

    public Transform player2;

    public Animator a1;

    public GameObject choice01, choice02, choice03, choice04, choice05, choice06,
        choice07, choice08, choice09, choice10, choice11, choice12, choice13,
        choice14, choice15, choice16, choice17, choice18, end;

    BoxCollider coll;

    // public BoxCollider bc, bc2, bc3, bc4, bc5, bc6, bc7, bc8, bc9, bc10, bc11,
    // bc12, bc13, bc14, bc15, bc16, bc17, bc18, bcEnd;

    void OnTriggerEnter(Collider other)
    {

        if (player2.transform.position.z < 220 && player2.transform.position.z >= 20)
        {
            switch (other.transform.name)
            {
                case "Choice01":
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 1'e");
                    coll = choice02.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    Destroy(choice01);
                    Destroy(choice02, 2);
                    coll = choice02.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    // bc.enabled = false;
                    // GENCLERLE BULUS
                    if (currentMoney>=10000)
                    {
                        currentMoney -= 10000;
                        moneyText.text = currentMoney.ToString();
                        currentOy += 1;
                        oyText.text = currentOy.ToString();
                    }
                    else if (currentMoney < 10000)
                    {
                        currentOy -= 1;
                        oyText.text = currentOy.ToString();
                    }
                    break;
                default:
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 2'ye");
                    coll = choice02.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    Destroy(choice02);
                    Destroy(choice01, 2);
                    coll = choice01.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc2.enabled = false;
                    // OTV ZAMMI
                    currentMoney += 20000;
                        moneyText.text = currentMoney.ToString();
                        currentOy -= 3;
                        oyText.text = currentOy.ToString();
                    break;
            }
        }


        if (player2.transform.position.z < 350 && player2.transform.position.z >= 310)
        {
            switch (other.transform.name)
            {
                case "Choice03":
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 3'e");
                    Destroy(choice03);
                    Destroy(choice04, 2);
                    coll = choice04.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc3.enabled = false;
                    // FABRIKA YAP
                    if (currentMoney >= 50000)
                    {
                        currentMoney -= 50000;
                        moneyText.text = currentMoney.ToString();
                        currentOy += 4;
                        oyText.text = currentOy.ToString();
                    }
                    else if (currentMoney < 50000)
                    {
                        currentOy -= 2;
                        oyText.text = currentOy.ToString();
                    }
                    break;
                default:
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 4'e");
                    Destroy(choice04);
                    Destroy(choice03, 2);
                    coll = choice03.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    // bc4.enabled = false;
                    // FABRIKA SAT
                    currentMoney += 30000;
                        moneyText.text = currentMoney.ToString();
                        currentOy -= 2;
                        oyText.text = currentOy.ToString();
                    break;
            }
        }

        if (player2.transform.position.z < 480 && player2.transform.position.z >= 440)
        {
            switch (other.transform.name)
            {
                case "Choice05":
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 5'e");
                    Destroy(choice05);
                    Destroy(choice06, 2);
                    coll = choice06.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc5.enabled = false;
                    // KOALISYON YAP
                    if (currentMoney >= 30000)
                    {
                        currentMoney -= 30000;
                        moneyText.text = currentMoney.ToString();
                        currentOy += 5;
                        oyText.text = currentOy.ToString();
                    }
                    else if (currentMoney < 30000)
                    {
                        currentOy -= 3;
                        oyText.text = currentOy.ToString();
                    }
                    break;
                default:
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 6'ya");
                    Destroy(choice06);
                    Destroy(choice05, 2);
                    coll = choice05.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc6.enabled = false;
                    // KOALISYON YAPMA
                    currentOy -= 3;
                        oyText.text = currentOy.ToString();
                    
                    break;
            }
        }

        if (player2.transform.position.z < 610 && player2.transform.position.z >= 570)
        {
            switch (other.transform.name)
            {
                case "Choice07":
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 7'ye");
                    Destroy(choice07);
                    Destroy(choice08, 2);
                    coll = choice08.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc7.enabled = false;
                    // KOPRU YAP
                    if (currentMoney >= 30000)
                    {
                        currentMoney -= 30000;
                        moneyText.text = currentMoney.ToString();
                        currentOy += 3;
                        oyText.text = currentOy.ToString();
                    }
                    else if (currentMoney < 30000)
                    {
                        currentOy -= 1;
                        oyText.text = currentOy.ToString();
                    }
                    break;
                default:
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 8'e");
                    Destroy(choice08);
                    Destroy(choice07, 2);
                    coll = choice07.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc8.enabled = false;
                    // TORPIL YAP
                    currentMoney += 30000;
                        moneyText.text = currentMoney.ToString();
                        currentOy -= 2;
                        oyText.text = currentOy.ToString();
                    break;
            }
        }

        if (player2.transform.position.z < 740 && player2.transform.position.z >= 700)
        {
            switch (other.transform.name)
            {
                case "Choice09":
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 9'a");
                    Destroy(choice09);
                    Destroy(choice10, 2);
                    coll = choice10.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc9.enabled = false;
                    // UNIVERSITE AC
                    if (currentMoney >= 20000)
                    {
                        currentMoney -= 20000;
                        moneyText.text = currentMoney.ToString();
                        currentOy += 2;
                        oyText.text = currentOy.ToString();
                    }
                    else if (currentMoney < 10000)
                    {
                        currentOy -= 1;
                        oyText.text = currentOy.ToString();
                    }
                    break;
                default:
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 10'a");
                    Destroy(choice10);
                    Destroy(choice09, 2);
                    coll = choice09.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc10.enabled = false;
                    // KYK BURSUNA ZAM YAPMA
                    currentMoney += 20000;
                        moneyText.text = currentMoney.ToString();
                        currentOy -= 1;
                        oyText.text = currentOy.ToString();

                    break;
            }
        }

        if (player2.transform.position.z < 870 && player2.transform.position.z >= 830)
        {
            switch (other.transform.name)
            {
                case "Choice11":
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 11'e");
                    Destroy(choice11);
                    Destroy(choice12, 2);
                    coll = choice12.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc11.enabled = false;
                    // SECIM ICIN HALKA PARA DAGIT
                    if (currentMoney >= 50000)
                    {
                        currentMoney -= 50000;
                        moneyText.text = currentMoney.ToString();
                        currentOy += 5;
                        oyText.text = currentOy.ToString();
                    }
                    else if (currentMoney < 10000)
                    {
                        currentOy -= 2;
                        oyText.text = currentOy.ToString();
                    }
                    break;
                default:
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 12'ye");
                    Destroy(choice12);
                    Destroy(choice11, 2);
                    coll = choice11.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc12.enabled = false;
                    // ARSA SAT
                    currentMoney += 40000;
                        moneyText.text = currentMoney.ToString();
                        currentOy -= 2;
                        oyText.text = currentOy.ToString();
                    break;
            }
        }

        if (player2.transform.position.z < 1000 && player2.transform.position.z >= 960)
        {
            switch (other.transform.name)
            {
                case "Choice13":
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 13'e");
                    Destroy(choice13);
                    Destroy(choice14, 2);
                    coll = choice14.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc13.enabled = false;
                    // CEPHEDE OPERASYON YAP
                    if (currentMoney >= 30000)
                    {
                        currentMoney -= 30000;
                        moneyText.text = currentMoney.ToString();
                        currentOy += 3;
                        oyText.text = currentOy.ToString();
                    }
                    else if (currentMoney < 10000)
                    {
                        currentOy -= 1;
                        oyText.text = currentOy.ToString();
                    }
                    break;
                default:
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 14'e");
                    Destroy(choice14);
                    Destroy(choice13, 2);
                    coll = choice13.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc14.enabled = false;
                    // KDV ZAMMI YAP
                    currentMoney += 30000;
                        moneyText.text = currentMoney.ToString();
                        currentOy -= 2;
                        oyText.text = currentOy.ToString();
                    break;
            }
        }

        if (player2.transform.position.z < 1130 && player2.transform.position.z >= 1090)
        {
            switch (other.transform.name)
            {
                case "Choice15":
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 15'e");
                    Destroy(choice15);
                    Destroy(choice16, 2);
                    coll = choice16.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc15.enabled = false;
                    // YOL YAP
                    if (currentMoney >= 30000)
                    {
                        currentMoney -= 10000;
                        moneyText.text = currentMoney.ToString();
                        currentOy += 2;
                        oyText.text = currentOy.ToString();
                    }
                    else if (currentMoney < 10000)
                    {
                        currentOy -= 1;
                        oyText.text = currentOy.ToString();
                    }
                    break;
                default:
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 16'ya");
                    Destroy(choice16);
                    Destroy(choice15, 2);
                    coll = choice15.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc16.enabled = false;
                    // KENDI MAASINA ZAM YAP
                    currentMoney += 30000;
                        moneyText.text = currentMoney.ToString();
                        currentOy -= 2;
                        oyText.text = currentOy.ToString();
                    break;
            }
        }

        if (player2.transform.position.z < 1260 && player2.transform.position.z >= 1220)
        {
            switch (other.transform.name)
            {
                case "Choice17":
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 17'ye");
                    Destroy(choice17);
                    Destroy(choice18, 2);
                    coll = choice18.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc17.enabled = false;
                    // KOALISYON YAP
                    if (currentMoney >= 30000)
                    {
                        currentMoney -= 30000;
                        moneyText.text = currentMoney.ToString();
                        currentOy += 5;
                        oyText.text = currentOy.ToString();
                    }
                    else if (currentMoney < 30000)
                    {
                        currentOy -= 3;
                        oyText.text = currentOy.ToString();
                    }
                    break;
                default:
                    //aSource.PlayOneShot(smallVoice, 1000f);
                    aSource = GetComponent<AudioSource>();
                    aSource.Play();
                    Debug.Log("çarptı 18'e");
                    Destroy(choice18);
                    Destroy(choice17, 2);
                    coll = choice17.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bc18.enabled = false;
                    // KOALISYON YAPMA
                    currentOy -= 3;
                        oyText.text = currentOy.ToString();
                    break;
            }
        }
        if (player2.transform.position.z < 1390 && player2.transform.position.z >= 1350)
        {
            switch (other.transform.name)
            {
                case "END":
                    Destroy(end);
                    coll = end.GetComponent<BoxCollider>();
                    coll.enabled = false;
                    //bcEnd.enabled = false;
                    if (currentOy >= 50)
                    {
                        Debug.Log("TEBRIKLER 5 YIL DAHA BASKANSIN!");
                    }
                    else if (currentOy < 50)
                    {
                        Debug.Log("MAALESEF %50 OY'UN ALTINDA KALDIN VE " +
                            "BASKAN OLAMADIN AMA ÜZÜLME ANA MUHALAFETSIN!");
                    }
                    break;
                default:
                    break;
            }

        }

    }

}


