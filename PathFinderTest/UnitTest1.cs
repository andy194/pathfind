namespace PathFinderTest
{
    public class Tests
    {
        Finder finder = new Finder();

        [SetUp]
        public void Setup()
        {
            finder.setMap(new List<string>
            {
                ". . . . .",
                ". # # # .",
                ". . . . .",
                ". . . . .",
                ". . . . ."
            });
        }

        [Test]
        public void TestGoal()
        {
            int distance = finder.findRoute(new Cell(0, 1), new Cell(3, 2));

            Assert.IsTrue(distance == 6);
        }

        [Test]
        public void TestGetAdjacent()
        {
            List<Cell> items = finder.GetAdjacent(new Cell(4, 4));

            Assert.IsTrue (items.Count == 2);
        }

        [Test]
        public void TestGetCell()
        {
            Cell? item = finder.getCell(0, 0);
            
            Assert.That(item, Is.Not.Null);

            item = finder.getCell(5, 0);

            Assert.That(item, Is.Null);
        }
    }
}