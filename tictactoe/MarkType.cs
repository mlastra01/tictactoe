using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The type of value a cell in the game is currently at
/// </summary>

namespace tictactoe
{
    public enum MarkType
    {
        /// The cell hasnt been clicked yet
        Free,
        ///The cell is  a O
        Nought,
        ///The cell is a X
        Cross
        
    }
}
