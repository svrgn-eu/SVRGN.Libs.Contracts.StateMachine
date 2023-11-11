using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.StateMachine
{
    public interface IStateTransition : IBaseObject, IName
    {
        #region Properties

        string FromState { get; }
        string ToState { get; }
        Action TransitionEnterAction { get; }
        Action TransitionAction { get; }
        Action TransitionExitAction { get; }

        #endregion Properties

        #region Methods

        void SetTransitionEnterAction(Action NewAction);
        void SetTransitionAction(Action NewAction);
        void SetTransitionExitAction(Action NewAction);

        #endregion Methods
    }
}
