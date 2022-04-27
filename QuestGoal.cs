using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal : MonoBehaviour
{
    public Quests quests;

    
  // public oxygenCan oxygencan;
    public GoalType goalType;

    public Collider playerCollider;

   // public GameObject questWindow;
    //public Text titleText;
    public int requiredAmount;
    public int currentAmount;
    

    [SerializeField] public questGiver questGiver;
    
    private void Start()
    {
        playerCollider = this.gameObject.GetComponent<CapsuleCollider>();
    }

    public bool IsReached()
    {
        return (currentAmount >= requiredAmount);

       // quests.Complete();
        Debug.Log("Goal Completed");
        quests.Complete();
        // questGiver.CloseQuestWindow();
        // questGiver.QuestCompleted();



    }
    public void ItemCollected()
    {
        if (goalType == GoalType.Gathering)
        {
            currentAmount++;
            questGiver.updateCounter(currentAmount);

        }
       

    }
    private void OnTriggerEnter(Collider collider)
    {        
        if (!IsReached())
        {
            if (collider.gameObject.tag == "SmallOxygenCan")
            {
                ItemCollected();
                Debug.Log("Item Collected: ");
                Debug.Log(currentAmount);
             
            }
            
        }
        if (IsReached())
        {
            
            {
                questGiver.CloseQuestWindow();
                Debug.Log("Goal Completed");
                // QuestManager.StartQuests(quests (quests));
                
                    quests.Complete();
                
                }
            }
        }
        


       
    }
   /// private void OnTriggerExit(Collider collider)
   // {
   //     questGiver.CloseQuestWindow();
   // }


public enum GoalType
{
    
    Gathering
}


        
     