using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Creational.Singleton
{
    public class ScrabbleSingleton
    {
        // Fields.
        private static ScrabbleSingleton _instance;
        public static ScrabbleSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ScrabbleSingleton();
                }
                return _instance;
            }
        }

        private char[] _letters =
        {
            'a', 'b', 'c', 'd', 'e', 'f'
        };
        private List<char> _availableLetters;

        // Properties.

        public IReadOnlyCollection<char> AllLetersInBag
        {
            get { return _letters; }
        }
        public IReadOnlyCollection<char> Availableletters
        {
            get { return _availableLetters; }
        }

        // Constructors.
        private ScrabbleSingleton()
        {
            _availableLetters = new List<char>(_letters);
        }

        // Methods.
        public List<char> GetLetterTiles(int numberOfTiles)
        {
            var tilesToSend = new List<char>();

            while(tilesToSend.Count < numberOfTiles)
            {
                var indexToPick = Random.Shared.Next(_availableLetters.Count);
                tilesToSend.Add(_availableLetters[indexToPick]);
                _availableLetters.RemoveAt(indexToPick);
            }

            return tilesToSend;
        }

    }
}
