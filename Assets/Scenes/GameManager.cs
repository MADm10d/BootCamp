using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public static GameManager instance;
    public string _stageName = "Stage Zero";
    public GMBaseState _currentState;
    public InitState _initState = new InitState();
    public LoadDataState _loadDataState = new LoadDataState();

    public void SwitchState(GMBaseState nextState)
    {
        _currentState.OnExitState(this);
        _currentState = nextState;
        _currentState.OnEnterState(this);
    }


    public void InitStateOnEnterState()
    {
        Debug.Log("this is on enter for init state");  
    }
    public void InitStateOnUpdateState()
    {
        Debug.Log("this is on update for init state");
    }
    public void InitStateOnExitState()
    {
        Debug.Log("this is on exit for init state");
    }


    public void DataLoadStateOnEnterState()
    {
        Debug.Log("this is on enter for load data state");
    }
    public void DataLoadStateOnUpdateState()
    {
        Debug.Log("this is on update for load data state");
    }
    public void DataLoadStateOnExitState()
    {
        Debug.Log("this is on exit for load data state");
    }


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);

        }

        _currentState = _initState;
        _initState.OnEnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        _currentState.OnUpdateState(this);
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SwitchState(_loadDataState);
        }
    }
}
