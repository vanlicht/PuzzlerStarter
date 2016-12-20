using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tGameLogic : MonoBehaviour
{

    #region Variables
    public GameObject player;
    public GameObject startUI, restartUI;
    public GameObject startPoint, playPoint, restartPoint;
    public bool playerwon = false;
    #endregion

    #region Main Methods
    void Start()
    {
        player.transform.position = startPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && player.transform.position == playPoint.transform.position)
        {
            puzzleSuccess();
        }
    }
    #endregion

    #region Utility Methods
    public void startPuzzle()
    {
        //begin puzzle sequence
        toggleUI();
        iTween.MoveTo(player, iTween.Hash("position", playPoint.transform.position, "time", 2, "easetype", "linear"));
    }


    public void resetPuzzle()
    {
        //reset puzzle sequence
        player.transform.position = startPoint.transform.position;
        toggleUI();
    }

    public void puzzleSuccess()
    {
        iTween.MoveTo(player, iTween.Hash("position", restartPoint.transform.position, "time", 2, "easetype", "linear"));
    }

    public void toggleUI()
    {
        startUI.SetActive(!startUI.activeSelf);
        restartUI.SetActive(!restartUI.activeSelf);
    }
    #endregion
    // Use this for initialization

}
