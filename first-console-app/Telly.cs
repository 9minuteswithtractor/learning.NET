
namespace TellyClass
{
    public class Telly
    {
        // attributes
        private int stringCount;

        // constructor
        public Telly()
        {
            stringCount = 0;
        }

        // methods
        public void AddOne()
        {
            stringCount++;
        }

        // getter
        public int GetCount()
        {
            return stringCount;
        }
    }
}
