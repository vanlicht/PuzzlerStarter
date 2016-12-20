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
    void startPuzzle()
    {
        toggleUI();
    }

    void toggleUI()
    {

    }

    void puzzleSuccess()
    {

    }
    #endregion
    // Use this for initialization

}
