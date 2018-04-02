using Morabaraba_2.Models;
using Morabaraba_2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Morabaraba_2.Models.GameStates;
using static Morabaraba_2.Models.ColorType;

namespace Morabaraba_2.Classes
{
    /// <summary>
    /// The board class holds a list of cows that are called nodes because each cow and its index within the list represents a node on the board.
    /// The index that the cow occupies will be used to move cows around the board, using a method that translates the index position within the list to a board position.
    /// It also holds gamestate to show whether the game is in progress or over.
    /// </summary>
    public class Board
    {
        private List<Cow> nodes;
        private GameState state;
        private PossibleMills mills;
        private Mills currentMills;

        public Board(List<Cow> nodes, GameState state)// Constructor for the board object
        {
            this.nodes = nodes ?? throw new ArgumentNullException(nameof(nodes));
            this.state = state;
            currentMills = new Mills();
        }

        public List<Cow> GetNodes()// returns all the nodes
        {
            return nodes;
        }

        public Cow GetNode(int index)// returns the cow value at a specified node
        {
            return nodes.ElementAt(index);
        }

        public void SetNode(int index, Cow cow)// sets the value of a node to the given cow value
        {
            nodes[index] = cow?? throw new ArgumentOutOfRangeException(nameof(index));
        }
        public bool CheckNodeForMill(int index,Player player)//Takes a node index and a player to see if that player has a mill from that node
        {
            Cow cow = player.GetCow();
            Mills mills = this.mills.GetMillsByIndex(index);
            foreach(Mill mill in mills.GetMills())
            {
                if (CheckMillAgainstBoard(mill, cow)) { currentMills.Add(mill); return true; }
            }
            return false;
        }

        private bool CheckMillAgainstBoard(Mill mill, Cow cow)//checks a specified possible mill against a type of cow to see if a mill has been created
        {
            bool check = false;
            List<int> list = mill.ToList();
            foreach(int i in list) { check = check || GetNode(i) == cow; }
            return check;
                         
        }
    }
}
