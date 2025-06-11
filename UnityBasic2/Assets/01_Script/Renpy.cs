using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
    [SerializeField] Image img_BG; //��� : ȣ�ó��� ��
    [SerializeField] Image[] img_Character; //ĳ����

    [SerializeField] TextMeshProUGUI txt_Name; //�̸� : ȣ�ó�
    [SerializeField] TextMeshProUGUI txt_NameTitle; //���� : �ູ
    [SerializeField] TextMeshProUGUI txt_Dialogue; //��� : �ȳ��ϼ���, ȣ�ó��Դϴ�.

  
    int id = 1; // ��� ID, 1������ �����Ѵ�. ��� ���̺��� ID �÷��� ������ �´�.

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
        int characterID = SData.GetDialogueData(id).Character; // ��� ���̺��� 1�� ID�� ĳ���� ID �÷��� ������ �´�.
        txt_Name.text = SData.GetCharacterData(characterID).Name; // ĳ���� ���̺��� ĳ���� ID�� �ش��ϴ� �̸��� ������ �´�.
        txt_NameTitle.text = SData.GetCharacterData(characterID).Title; // ĳ���� ���̺��� ĳ���� ID�� Ÿ��Ʋ�� ������ �´�.

        txt_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    }
    void Update()
    {

    }
}
