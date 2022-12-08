using System.Collections;
using UnityEngine;


namespace KUMO
{ 
    /// <summary>
    /// 學習偕同程式，簡稱協程 Coroutine
    /// 目的:讓程式達到停留的效果
    /// </summary>
public class LearnCoroutine : MonoBehaviour
{
        //使用偕同程式的四個條件
        //1.引用命名空間 System.Collections
        //2.定義一個傳回 IEnumerator
        //3.方法內必須使用 yield return
        //4.使用 StartCoroutine 啟動

        //字串 string 為 char 陣列
        private string testDialogue = "我在哪裡?";

        private void Awake()
        {
            //StartCoroutine(Test());

            //print("取得測試對話的第一個字:" + testDialogue[0]);

            //StartCoroutine(ShowDialogue());
            StartCoroutine(ShowDialogueUseFor());
        }

        private IEnumerator Test()
        {
            print("<color= #33ff33>第一行程式</Color>");
            yield return new WaitForSeconds(2);
            print("<color=#ff3333>第二行程式</color>");
            yield return new WaitForSeconds(3);
            print("<color=#ff3333>第三行程式</color>");

        }

        private IEnumerator ShowDialogue()
        {
            print(testDialogue[0]);
            yield return new WaitForSeconds(0.1f);
            print(testDialogue[1]);
            yield return new WaitForSeconds(0.1f);
            print(testDialogue[2]);
            yield return new WaitForSeconds(0.1f);


        }

        private IEnumerator ShowDialogueUseFor()
        {
            for (int i = 0; i < testDialogue.Length; i++)
            {
                print(testDialogue[i]);
                yield return new WaitForSeconds(0.2f);
            }
        }


    }

}