using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.StateMachine
{
    public interface IUseStateMachine
    {
        #region Properties

        IStateMachine StateMachine { get; }

        #endregion Properties

        #region Methods

        void InjectStateMachine(IStateMachine StateMachine);

        #endregion Methods
    }
}
