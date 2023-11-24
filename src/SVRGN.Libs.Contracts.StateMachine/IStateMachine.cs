using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.StateMachine
{
    public interface IStateMachine : IBaseObject, IUpdate, IClear, IToMermaid, IFromMermaid
    {
        #region Properties

        #region StateCount: the total number of states
        /// <summary>
        /// the total number of states
        /// </summary>
        int StateCount { get; }
        #endregion StateCount

        #region TransitionCount: the total number of transitions
        /// <summary>
        /// the total number of transitions
        /// </summary>
        int TransitionCount { get; }
        #endregion TransitionCount

        #endregion Properties

        #region Methods

        #region SetUpdateInterval
        void SetUpdateInterval(TimeSpan NewInterval);
        #endregion SetUpdateInterval

        #region AddState: Adds a new state
        /// <summary>
        /// Adds a new state
        /// </summary>
        /// <param name="StateName">the name of the new state</param>
        /// <returns>true if successful, false if the state already exists</returns>
        bool AddState(string StateName);
        #endregion AddState

        #region StartWith: set the start state
        /// <summary>
        /// set the start state
        /// </summary>
        /// <param name="StateName">the name of the starting state, if the state name does not exist, the first transition will fail</param>
        void StartWith(string StateName);
        #endregion StartWith

        #region AddTransition
        bool AddTransition(string TransitionName, string FromStateName, string ToStateName);
        #endregion AddTransition

        #region AddTransitionEnterAction
        bool AddTransitionEnterAction(string TransitionName, Action ActionToTake);
        #endregion AddTransitionEnterAction

        #region AddTransitionAction
        bool AddTransitionAction(string TransitionName, Action ActionToTake);
        #endregion AddTransitionAction

        #region AddTransitionExitAction
        bool AddTransitionExitAction(string TransitionName, Action ActionToTake);
        #endregion AddTransitionExitAction

        #region AddStateEnterAction
        bool AddStateEnterAction(string StateName, Action ActionToTake);
        #endregion AddStateEnterAction

        #region AddStateUpdateAction
        bool AddStateUpdateAction(string StateName, Action ActionToTake);
        #endregion AddStateUpdateAction

        #region AddStateExitAction
        bool AddStateExitAction(string StateName, Action ActionToTake);
        #endregion AddStateExitAction

        #region Transition: performs a transition by it's name
        /// <summary>
        /// performs a transition by it's name
        /// </summary>
        /// <param name="TransitionName">the name of the transition</param>
        /// <returns>true, if the transition has been performed successfully, false if the transition has not been found</returns>
        bool Transition(string TransitionName);
        #endregion Transition

        #region TransitionTo: Transitions into a Target state, the state machine will check, if possible and then do the transition
        /// <summary>
        /// Transitions into a Target state, the state machine will check, if possible and then do the transition
        /// </summary>
        /// <param name="TargetStateName">The name of the target state</param>
        /// <returns>true, if the target state exists and a transition from current to target state could be performed successfully</returns>
        bool TransitionTo(string TargetStateName);
        #endregion TransitionTo

        #region GetCurrentStateName: returns the name of the currently active state
        /// <summary>
        /// returns the name of the currently active state
        /// </summary>
        /// <returns>the name of the currently active state</returns>
        string GetCurrentStateName();
        #endregion GetCurrentStateName

        #endregion Methods
    }
}
