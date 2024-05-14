using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEditorInternal;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private UIManager uiManager;
    public GameObject player{ get; private set; }
    public GameObject playerPrefab;

    public RuntimeAnimatorController[] controller;
    private void Awake()
    {
        if (Instance != null) Destroy(this.gameObject);
        Instance = this;
    }
    public void Start()
    {
        uiManager.UI_SetCharacter.SetActive(true);
    }

    public void GameStart(string nickname, int idx)
    {
        GameObject go = Instantiate(playerPrefab);
        player = go;
        ChangePlayerChatarcter(idx);
        TextMeshProUGUI playertext = go.GetComponentInChildren<TextMeshProUGUI>();
        playertext.text = nickname;
        uiManager.UI_SetCharacter.SetActive(false);
        uiManager.UI_Game.SetActive(true);
        Camera camera = Camera.main;
        camera.GetOrAddComponent<CameraController>().Player = go.transform;
    }
   public void ChangeNickName(string nickname)
    {
        TextMeshProUGUI playertext = player.GetComponentInChildren<TextMeshProUGUI>();
        playertext.text = nickname;
    }
    public void ChangePlayerChatarcter(int idx)
    {
        Animator anim = player.GetComponent<Animator>();
        anim.runtimeAnimatorController = controller[idx];
    }
}
