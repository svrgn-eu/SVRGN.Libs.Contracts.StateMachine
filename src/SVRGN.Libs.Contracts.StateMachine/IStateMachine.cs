using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.StateMachine
{
    public interface IStateMachine : IBaseObject, IUpdate, IClear, IToMermaid, IFromMermaid
    {
        #region Properties
        int StateCount { get; }
        int TransitionCount { get; }

        #endregion Properties

        #region Methods

        void SetUpdateInterval(TimeSpan NewInterval);
        bool AddState(string StateName);
        void StartWith(string StateName);
        bool AddTransition(string TransitionName, string FromStateName, string ToStateName);
        bool AddTransitionEnterAction(string TransitionName, Action ActionToTake);
        bool AddTransitionAction(string TransitionName, Action ActionToTake);
        bool AddTransitionExitAction(string TransitionName, Action ActionToTake);
        bool AddStateEnterAction(string StateName, Action ActionToTake);
        bool AddStateUpdateAction(string StateName, Action ActionToTake);
        bool AddStateExitAction(string StateName, Action ActionToTake);
        bool Transition(string TransitionName);
        string GetCurrentStateName();

        #endregion Methods
    }
}
