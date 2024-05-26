using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Dialogue4month6_
{
    [TextArea]
    public string dialogueText; // �ʵ� �̸��� dialogueText�� ����
    public int characterIndex; // ĳ���� �ε���
}

public class panda6 : MonoBehaviour
{
    public Image Dialogue_box;
    public Image[] characterImages; // ĳ���� �̹��� �迭
    public Text Dialogue_text;
    public Button select1;
    public Button select2;
    public Button select3;
    public GameObject SelectBox3;
    public GameObject Dialogue4Manager6;
    public GameObject Dialogue4Manager7;
    public GameObject Dialogue4Manager8;
    public GameObject Dialogue4Manager9;

    public Image backgroundImage; // ��� �̹���
    public Sprite AIimage; // panda �̹��� ��������Ʈ

    private float re;
    private bool IsDialogue = false;
    private int count = 0;

    public Dialogue4month1_[] dialogues;

    void Start()
    {
        // ĳ���� �̹������� �ʱ�ȭ�մϴ�.
        foreach (var image in characterImages)
        {
            image.gameObject.SetActive(false);
        }

        if (SelectBox3 != null)
        {
            SelectBox3.gameObject.SetActive(false);
        }
        re = 1;

        StartDialogue();
    }

    public void StartDialogue()
    {
        if (re == 1)
        {
            Dialogue_box.gameObject.SetActive(true);
            Dialogue_text.gameObject.SetActive(true);
            ShowCharacterImages(dialogues[count].characterIndex); // ù ��° ��ȭ�� �ش��ϴ� ĳ���� �̹����� Ȱ��ȭ�մϴ�.
            count = 0;
            IsDialogue = true;
            NextDialogue();
        }

    }

    public void NextDialogue()
    {
        // ���⸦ �ݿ��Ͽ� ��� �ؽ�Ʈ�� �����մϴ�.
        Dialogue_text.text = dialogues[count].dialogueText.Replace("\\n", "\n");
        ShowCharacterImages(dialogues[count].characterIndex); // �ش� ��ȭ�� �ش��ϴ� ĳ���� �̹����� Ȱ��ȭ�մϴ�.
        if (count == 7)
        {
            backgroundImage.sprite = AIimage;
        }
        count++;
        
    }

    public void EndDialogue()
    {
        Dialogue_box.gameObject.SetActive(false);
        Dialogue_text.gameObject.SetActive(false);
        IsDialogue = false;


        select1.onClick.AddListener(DialogueSelect7);
        select2.onClick.AddListener(DialogueSelect8);
        select3.onClick.AddListener(DialogueSelect9);


    }

    private void DialogueSelect7()
    {
        SelectBox3.gameObject.SetActive(false);
        Dialogue4Manager7.gameObject.SetActive(true);
        Dialogue4Manager6.gameObject.SetActive(false);
    }

    private void DialogueSelect8()
    {
        SelectBox3.gameObject.SetActive(false);
        Dialogue4Manager8.gameObject.SetActive(true);
        Dialogue4Manager6.gameObject.SetActive(false);
    }

    private void DialogueSelect9()
    {
        SelectBox3.gameObject.SetActive(false);
        Dialogue4Manager9.gameObject.SetActive(true);
        Dialogue4Manager6.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (IsDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialogues.Length)
                {
                    NextDialogue();
                }
                else
                {
                    re = 2;
                    EndDialogue();
                    SelectBox3.gameObject.SetActive(true);
                }
            }
        }
    }

    // �ش� �ε����� �ش��ϴ� ĳ���� �̹����� Ȱ��ȭ�ϰ� �������� ��Ȱ��ȭ�մϴ�.
    private void ShowCharacterImages(int index)
    {
        for (int i = 0; i < characterImages.Length; i++)
        {
            characterImages[i].gameObject.SetActive(i == index);
        }
    }
}