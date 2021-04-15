using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinLose : MonoBehaviour

{
    public GameObject winner;
    public GameObject loser;
    public GameObject next;
    public GameObject again;
    bool gameEnded = false;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(score==10){
            winner.SetActive(true);
            Next();
        }
        else{
            loser.SetActive(false);
            Again();
        }
    }
    // private void ChangeStatus(){
    //     if(score==10){
    //         winner.SetActive(true);
    //         Next();
    //     }
    //     else{
    //         loser.SetActive(false);
    //         Again();
    //     }

    // }

    public void Next(){
        SceneManager.LoadScene("Level2");
    }

    public void Again(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
