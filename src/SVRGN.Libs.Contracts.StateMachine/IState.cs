using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.StateMachine
{
    public interface IState : IBaseObject, IName
    {
        #region Properties

        Action EnterAction { get; }
        Action UpdateAction { get; }
        Action ExitAction { get; }

        #endregion Properties

        #region Methods

        void SetEnterAction(Action NewEnterAction);
        void SetUpdateAction(Action NewUpdateAction);
        void SetExitAction(Action NewExitAction);

        #endregion Methods
    }
}
