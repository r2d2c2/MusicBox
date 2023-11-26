using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;
using DG.Tweening;
using Unity.VisualScripting;

public class start : MonoBehaviour
{

    [SerializeField] private AudioSource m_AudioSource;
    [SerializeField] private AudioClip[] mySound;
    [Header("음 순서로 등록할것")]
    [SerializeField] private Image[] ButtonDisplay;//게임 오브젝트 저장



   
    IEnumerator SoundFun(int i)
    {
        ButtonDisplay[i].color = Color.black;
        print(i + " 사운드 출력");
        m_AudioSource.clip = mySound[i];
        m_AudioSource.Play();
        
        yield return m_AudioSource.playOnAwake;//사운드 모든 시간 출력
        yield return new WaitForSeconds(0.1f);
        ButtonDisplay[i].color = Color.white;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(SoundFun(0));
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            StartCoroutine(SoundFun(1));
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            StartCoroutine(SoundFun(2));
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            StartCoroutine(SoundFun(3));
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            StartCoroutine(SoundFun(4));
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            StartCoroutine(SoundFun(5));
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            StartCoroutine(SoundFun(6));
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            StartCoroutine(SoundFun(7));
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            StartCoroutine(SoundFun(8));
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            StartCoroutine(SoundFun(9));
        }
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            StartCoroutine(SoundFun(10));
        }
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            StartCoroutine(SoundFun(11));
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(SoundFun(12));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine(SoundFun(13));
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(SoundFun(14));
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(SoundFun(15));
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            StartCoroutine(SoundFun(16));
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            StartCoroutine(SoundFun(17));
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            StartCoroutine(SoundFun(18));
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            StartCoroutine(SoundFun(19));
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            StartCoroutine(SoundFun(20));
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine(SoundFun(21));
        }
        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            StartCoroutine(SoundFun(22));
        }
        if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            StartCoroutine(SoundFun(23));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(SoundFun(24));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(SoundFun(25));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            StartCoroutine(SoundFun(26));
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(SoundFun(27));
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            StartCoroutine(SoundFun(28));
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            StartCoroutine(SoundFun(29));
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            StartCoroutine(SoundFun(30));
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            StartCoroutine(SoundFun(31));
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            StartCoroutine(SoundFun(32));
        }
        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            StartCoroutine(SoundFun(33));
        }
        if (Input.GetKeyDown(KeyCode.Quote))
        {
            StartCoroutine(SoundFun(34));
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            StartCoroutine(SoundFun(35));
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            StartCoroutine(SoundFun(36));
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine(SoundFun(37));
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            StartCoroutine(SoundFun(38));
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            StartCoroutine(SoundFun(39));
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            StartCoroutine(SoundFun(40));
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            StartCoroutine(SoundFun(41));
        }
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            StartCoroutine(SoundFun(42));
        }
        if (Input.GetKeyDown(KeyCode.Period))
        {
            StartCoroutine(SoundFun(43));
        }
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            StartCoroutine(SoundFun(44));
        }
        
    }
}
