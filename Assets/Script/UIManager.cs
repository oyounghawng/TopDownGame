using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;
using UnityEngine.InputSystem;
using System.Xml.Linq;
public class UIManager : MonoBehaviour
{
    private int Characteridx = 0;
    [Header("UI_SetCharacter")]
    public GameObject UI_SetCharacter;
    [SerializeField] private TMP_InputField inputNickName;
    [SerializeField] private GameObject CharacterSelectButton;
    [SerializeField] Sprite[] CharacterImages;

    [Header("UI_Game")]
    public GameObject UI_Game;
    [SerializeField] private TextMeshProUGUI timeText;

    [Header("UI_ChangeNickName")]
    public GameObject UI_ChangeNickName;
    [SerializeField] private TMP_InputField inputChangeNickName;

    private void Start()
    {

    }
    private void Update()
    {
        timeText.text = DateTime.Now.ToString("HH:mm");
    }
    public void SetImage(int idx)
    {
        Image image = CharacterSelectButton.GetComponent<Image>();
        image.sprite = CharacterImages[idx];
        Characteridx = idx;
    }
    public void SetCharacterInfo()
    {
        //닉네임 설정
        if (inputNickName.text.Length < 2)
        {
            inputNickName.text = "닉네임은 두글자 이상이어야 합니다.";
            return;
        }
        string Name = inputNickName.text;
        GameManager.Instance.GameStart(Name, Characteridx);
    }

    public void ChangeNickName()
    {
        if (inputChangeNickName.text.Length < 2)
        {
            inputChangeNickName.text = "닉네임은 두글자 이상이어야 합니다.";
            return;
        }
        string Name = inputChangeNickName.text;
        GameManager.Instance.ChangeNickName(Name);
        UI_ChangeNickName.SetActive(false);
    }

    public void ChangePlayerCharacter(int idx)
    {
        GameManager.Instance.ChangePlayerChatarcter(idx);
    }
}
