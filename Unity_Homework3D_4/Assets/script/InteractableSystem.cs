
using UnityEngine;
using UnityEngine.Events;
namespace KUMO
{
    /// <summary>
    /// 互動系統:偵測玩家是否進入並且執行互動行為
    /// </summary>

    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;
        [SerializeField, Header("對話結束後的事件")]
        private UnityEvent onDialogueFinish;

        [SerializeField, Header("啟動道具")]
        private GameObject propActive;
        [SerializeField, Header("啟動後的對話資料")]
        private DialogueData dataDialogueActive;

        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("畫布對話系統").GetComponent<DialogueSystem>();
        }

        //3D物件適用
        //兩個碰撞物件必須其中之一勾選 Is Trigger
        //碰撞開始
        private void OnTriggerEnter(Collider other)
        {
            if(other.name.Contains(nameTarget))
            {
                print(other.name);
                if(propActive == null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);

                }
                else
                {
                    dialogueSystem.StartDialogue(dataDialogueActive);
                }
                
            }
        }

        //碰撞結束
        private void OnCollisionExit(Collision collision)
        {
            
        }

        //碰撞持續
        private void OnCollisionStay(Collision collision)
        {
            
        }

        /// <summary>
        /// 隱藏物件
        /// </summary>
         
        public void HiddenObject()
        {

            gameObject.SetActive(false);
        }
    }
}