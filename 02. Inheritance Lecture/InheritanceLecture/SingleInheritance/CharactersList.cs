namespace SingleInheritance
{
    using System.Collections;
    using System.Collections.Generic;
    public class CharactersList : IEnumerable<Character>
    {
        private List<Character> characters;

        public CharactersList()
        {
            this.characters = new List<Character>();
        }

        public void Add(Character character)
        {
            characters.Add(character);
        }
        public IEnumerator<Character> GetEnumerator()
        {
            foreach (var character in characters)
            {
                yield return character;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
