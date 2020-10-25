using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIDE_Data;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public GameObject NPC_Container;
    public GameObject Player_Container;
    public GameObject textBox;
    public Text NPC_Text;
    public Text NPC_Name;


    
    public Image NPCSprite;
    public Image PlayerSprite;

    public Text[] choice_Texts;

    public GameObject Apartments;
    public GameObject Cafe1;
    public GameObject Cafe2;
    public GameObject Cafe3;
    public GameObject Cinema1;
    public GameObject Cinema2;
    public GameObject Cinema3;
    public GameObject School1;
    public GameObject School2;
    public GameObject School3;
    public GameObject Town1;
    public GameObject Town2;
    public GameObject Town3;


    // Start is called before the first frame update
    void Start()
    {
        NPC_Container.SetActive(false);
        Player_Container.SetActive(false);
        textBox.SetActive(false);
        
    }

    public void YoshikoOutOfScreen()
    {

    }

    public void YoshikoOnScreen()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
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

    public void SpeechClick ()

    {
        if(!VD.isActive)
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
       
        
        NPCSprite.sprite = null;


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
            if (data.sprite != null)

            {
                NPCSprite.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 0f);
                NPCSprite.sprite = data.sprite;
            }

            else if (VD.assigned.defaultNPCSprite != null)

                NPCSprite.sprite = VD.assigned.defaultNPCSprite;
            
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
        textBox.SetActive(true);
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
