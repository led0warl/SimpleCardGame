﻿namespace SimpleCardGames.Battle
{
    /// <summary>
    ///     Start Current player Turn Implementation.
    /// </summary>
    public class StartPlayerTurnMechanics : BaseGameMechanics
    {
        public StartPlayerTurnMechanics(IGame game) : base(game)
        {
        }

        /// <summary>
        ///     Start current player turn logic.
        /// </summary>
        public void Execute()
        {
            if (Game.IsTurnInProgress)
                return;
            if (!Game.IsGameStarted)
                return;
            if (Game.IsGameFinished)
                return;


            Game.IsTurnInProgress = true;
            Game.TurnLogic.UpdateCurrentPlayer();
            Game.TurnLogic.CurrentPlayer.StartTurn();

            OnStartedCurrentPlayerTurn(Game.TurnLogic.CurrentPlayer);
        }

        /// <summary>
        ///     Dispatch start current player turn to the listeners.
        /// </summary>
        /// <param name="currentPlayer"></param>
        private void OnStartedCurrentPlayerTurn(IPlayer currentPlayer)
        {
            GameEvents.Instance.Notify<IStartPlayerTurn>(i => i.OnStartPlayerTurn(currentPlayer));
        }
    }
}