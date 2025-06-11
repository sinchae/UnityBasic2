using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
    [SerializeField] Image img_BG; //배경 : 호시노의 방
    [SerializeField] Image[] img_Character; //캐릭터

    [SerializeField] TextMeshProUGUI txt_Name; //이름 : 호시노
    [SerializeField] TextMeshProUGUI txt_NameTitle; //감정 : 행복
    [SerializeField] TextMeshProUGUI txt_Dialogue; //대사 : 안녕하세요, 호시노입니다.

  
    int id = 1; // 대사 ID, 1번부터 시작한다. 대사 테이블의 ID 컬럼을 가지고 온다.

    void Start()
    {
        RefreshUI();
    }

    public void OnClickButton()
    {
        id++; // 2
        RefreshUI();
    }

    void RefreshUI()
    {
        int characterID = SData.GetDialogueData(id).Character; // 대사 테이블의 1번 ID의 캐릭터 ID 컬럼을 가지고 온다.
        txt_Name.text = SData.GetCharacterData(characterID).Name; // 캐릭터 테이블에서 캐릭터 ID에 해당하는 이름을 가지고 온다.
        txt_NameTitle.text = SData.GetCharacterData(characterID).Title; // 캐릭터 테이블에서 캐릭터 ID에 타이틀을 가지고 온다.

        txt_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    }
    void Update()
    {

    }
}
