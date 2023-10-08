using ChessLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumpadChessUnitTests
{
    public class Coordinates2D_Tests
    {
        [Test]
        public void Add_Coordinates()
        {
            // Adding zeros
            Coordinates2D coord1 = new Coordinates2D(0, 0);
            Coordinates2D coord2 = new Coordinates2D(0, 0);
            Coordinates2D coordResult = coord1 + coord2;
            Assert.That(0, Is.EqualTo(coordResult.Row));
            Assert.That(0, Is.EqualTo(coordResult.Col));

            //Adding Positives
            coord1 = new Coordinates2D(1, 1);
            coord2 = new Coordinates2D(1, 1);
            coordResult = coord1 + coord2;
            Assert.That(2, Is.EqualTo(coordResult.Row));
            Assert.That(2, Is.EqualTo(coordResult.Col));

            // Adding Negatives
            coord1 = new Coordinates2D(-1, -1);
            coord2 = new Coordinates2D(-1, -1);
            coordResult = coord1 + coord2;
            Assert.That(-2, Is.EqualTo(coordResult.Row));
            Assert.That(-2, Is.EqualTo(coordResult.Col));

            // Adding Positives To Negatives
            coord1 = new Coordinates2D(1, 1);
            coord2 = new Coordinates2D(-1, -1);
            coordResult = coord1 + coord2;
            Assert.That(0, Is.EqualTo(coordResult.Row));

            // Adding Negative to Positive
            coord1 = new Coordinates2D(-1, -1);
            coord2 = new Coordinates2D(1, 1);
            coordResult = coord1 + coord2;
            Assert.That(0, Is.EqualTo(coordResult.Row));
        }

        [Test]
        public void Subtract_Coordinates()
        {
            // Subtracting zeros
            Coordinates2D coord1 = new Coordinates2D(0, 0);
            Coordinates2D coord2 = new Coordinates2D(0, 0);
            Coordinates2D coordResult = coord1 - coord2;
            Assert.That(0, Is.EqualTo(coordResult.Row));

            // Subtracting Positives
            coord1 = new Coordinates2D(1, 1);
            coord2 = new Coordinates2D(1, 1);
            coordResult = coord1 - coord2;
            Assert.That(0, Is.EqualTo(coordResult.Row));

            // Subtracting Negatives
            coord1 = new Coordinates2D(-1, -1);
            coord2 = new Coordinates2D(-1, -1);
            coordResult = coord1 - coord2;
            Assert.That(0, Is.EqualTo(coordResult.Row));

            // Subtracting Positives From Negatives
            coord1 = new Coordinates2D(1, 1);
            coord2 = new Coordinates2D(-1, -1);
            coordResult = coord1 - coord2;
            Assert.That(2, Is.EqualTo(coordResult.Row));

            // Subtracting Negative From Positive
            coord1 = new Coordinates2D(-1, -1);
            coord2 = new Coordinates2D(1, 1);
            coordResult = coord1 - coord2;
            Assert.That(-2, Is.EqualTo(coordResult.Row));

        }
    }
}
