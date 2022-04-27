using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class questGiver : MonoBehaviour
{
    public Quests quests;

    public GameObject Completed;

    //public GameObject player;

    public GameObject player;

    public GameObject questWindow;

    public GameObject questGivers;
    public QuestManager manager;
    public QuestGoal questgoal;

    

    public Text titleText;
    public Text descriptionText;
  


    void Start()
    {

        GameObject.FindGameObjectWithTag("Player").GetComponent<questGiver>();
    }


    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        
       // questgiver.SetActive(true);
        //questWindow.SetActive(true);
        titleText.text = "Oxygen Tasks";
        descriptionText.text = /*quests.description*/ "Collect Small Oxygen Cannisters 0/3";
        quests.isActive = true;
        Completed.SetActive(false);

    }

    public void OpenQuestWindow()
    {
        if (quests.isActive == true)
        {
            questWindow.SetActive(true);
            titleText.text = "Oxygen Tasks";
            descriptionText.text = /*quests.description*/ "Collect Small Oxygen Cannisters 0/3";
            Completed.SetActive(false);

        }
        if (!quests.isActive == false)
        {
            titleText.text = "Quick Search";
            descriptionText.text = /*quests.description*/ "Find Control Room";
            questWindow.SetActive(true);
        }
      
    }

    public void updateCounter(int count)
    {
        descriptionText.text = "Collect Small Oxygen Cannisters " + count + "/3";
    }

   
    public void QuestCompleted()
    {
        
        
            quests.isActive = false;
            questWindow.SetActive(false);
            Completed.SetActive(true);
        
    }

    public void CloseQuestWindow()
    {
        if (quests.isActive == false)
        {
            questWindow.SetActive(false);
            //titleText.text = quests.title;
            //descriptionText.text = /*quests.description*/ "Collect Small Oxygen Cannisters 0/3";
            Completed.SetActive(false);
          
        }
       
       
    }
   public void OnTriggerExit(Collider other)
    {
        // quests.Complete();
        Debug.Log("Object Exited the trigger");
        FindObjectOfType<QuestManager>().EndQuests();
        questWindow.SetActive(false);
        Completed.SetActive(false);
    }



}