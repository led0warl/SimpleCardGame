﻿using Tools;

namespace SimpleCardGames.Battle
{
    /// <summary>
    ///     A concrete board that holds characters in specific positions. This class
    ///     can be ignored  if this structure is not present in the game design.
    /// </summary>
    public class Board : IBoard
    {
        public Board(Collection<ICharacter> characters, Collection<IBoardPosition> positions)
        {
            Characters = characters;
            Positions = positions;
            CreateBoard();
        }

        public Collection<ICharacter> Characters { get; }
        public Collection<IBoardPosition> Positions { get; }

        public void CreateBoard()
        {
            OnCreateBoard();
        }

        /// <summary>
        ///     Clear all positions and characters on the board.
        /// </summary>
        public void Clear()
        {
            Positions.Clear();
            Characters.Clear();
        }

        /// <summary>
        ///     Adds a character to the board into a specific position.
        /// </summary>
        /// <param name="character"></param>
        /// <param name="pos"></param>
        public void AddCharacter(ICharacter character, IBoardPosition pos)
        {
        }

        /// <summary>
        ///     Removes a character from a specific position.
        /// </summary>
        /// <param name="character"></param>
        /// <param name="pos"></param>
        public void RemoveTile(ICharacter character, IBoardPosition pos)
        {
        }

        /// <summary>
        ///     Get an specific position on the board.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public BoardPosition GetPosition(BoardPosition pos)
        {
            return null;
        }

        private void OnAddTile(ICharacter tile, IBoardPosition pos)
        {
        }

        private void OnRemoveTile(ICharacter tile, IBoardPosition pos)
        {
        }

        private void OnCreateBoard()
        {
        }
    }
}