using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIDE_Data;
using UnityEngine.UI;

public class UIManagerStart : MonoBehaviour
{

    public GameObject NPC_Container;
    public GameObject Player_Container;
    public GameObject textBox;
    public Text NPC_Text;
    public Text NPC_Name;
    public GameObject background;
    public GameObject townBackground;




    public Text[] choice_Texts;




    // Start is called before the first frame update
    void Start()
    {
    NPC_Container.SetActive(false);
    Player_Container.SetActive(false);
    textBox.SetActive(false);

    if (Input.GetKeyDown(KeyCode.Return))
    {
       if (!VD.isActive)
       {
            Begin();
       }
       else
       {
            VD.Next();
       }
    }

    }


// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!VD.isActive)
        {
            Begin();
        }
        else
        {
            VD.Next();
        }
        }
    }

    public void BackgroundOn()
    {
        background.SetActive(true);
    }
    public void townBackgroundOn()
    {
        townBackground.SetActive(true);
    }

    public void SpeechClick()

    {
    if (!VD.isActive)
    {
        Begin();
    }
    else
    {
        VD.Next();
    }
    }

    void Begin()
    {
        VD.OnNodeChange += UpdateUI;
        VD.OnEnd += End;
        VD.BeginDialogue(GetComponent<VIDE_Assign>());
    }

    void UpdateUI(VD.NodeData data)
    {
        NPC_Container.SetActive(false);
        Player_Container.SetActive(false);


       

    if (data.isPlayer)
    {
        Player_Container.SetActive(true);
        textBox.SetActive(true);

        for (int i = 0; i < choice_Texts.Length; i++)
        {
            if (i < data.comments.Length)
            {
                choice_Texts[i].transform.parent.gameObject.SetActive(true);
                choice_Texts[i].text = data.comments[i];
            }
            else
            {
                choice_Texts[i].transform.parent.gameObject.SetActive(false);
            }
        }
    }
    else
    {
        /*if(data.sprite = null)

           NPCSprite.GetComponent<RectTransform>().anchoredPosition = new Vector2(-10f, 0f);

        */


        textBox.SetActive(true);
        NPC_Container.SetActive(true);
        NPC_Text.text = data.comments[data.commentIndex];
        NPC_Name.text = data.tag;
    }
}

    void End(VD.NodeData data)
    {
        NPC_Container.SetActive(false);
        Player_Container.SetActive(false);
        textBox.SetActive(false);
        VD.OnNodeChange -= UpdateUI;
        VD.OnEnd -= End;
        VD.EndDialogue();
    }

    void OnDisable()
    {
    if (NPC_Container != null)
        End(null);
    }

    public void SetPlayerChoice(int choice)
    {
        VD.nodeData.commentIndex = choice;
        if (Input.GetMouseButtonUp(0))
        VD.Next();
    }

}

