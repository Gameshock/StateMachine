using UnityEngine;
using Cysharp.Threading.Tasks;
using State = StateMachine<GameState>.State;
using Unity.VisualScripting;
using System.Linq;
using UnityEngine.EventSystems;

public class GameState : MonoBehaviour
{
    private StateMachine<GameState> stateMachine;

    private enum EventType : int
    {
        // ゲーム開始
        Strat,
    }


    void Start()
    {
        stateMachine = new StateMachine<GameState>(this);

        // ゲーム開始時
        stateMachine.Start<StateStart>();
    }

    void Update()
    {
        stateMachine.Update();
    }

    /// <summary>
    /// ゲーム開始時ステート
    /// </summary>
    public class StateStart : State
    {
        protected override async void OnEnter(State prevState)
        {

        }

        protected override void OnUpdate()
        {

        }

        protected override void OnExit(State nextState)
        {

        }
    }
}
