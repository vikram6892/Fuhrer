
using System;

namespace ConstructorExample
{
    public class TestComposition
    {
        int value;
        TestComposition up;
        TestComposition down;

        TestComposition(int _value)
        {
            value = _value;
        }

        public static void Main(string[] args)
        {
            TestComposition startNode = new TestComposition(7);
            startNode.down = new TestComposition(5);
            startNode.up = new TestComposition(10);

            TestComposition tmpComp = startNode.up;
            tmpComp.down = new TestComposition(22);
            tmpComp = tmpComp.down;
            tmpComp.up = new TestComposition(17);
            startNode.down.up = new TestComposition(4);
            return;
        }
    }
}
