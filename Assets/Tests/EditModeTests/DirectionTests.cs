using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DirectionTests
    {
        private Direction north = new Direction("north");
        private Direction east = new Direction("east");
        private Direction south = new Direction("south");
        private Direction west = new Direction("west");
        // A Test behaves as an ordinary method
        [Test]
        public void North()
        {
            Assert.AreEqual(expected:new Vector3(x:0, y:1, z:0), actual:north.GetVector());
        }

        public void East()
        {
            Assert.AreEqual(expected:new Vector3(x:1, y:0, z:0), actual:east.GetVector());
        }

        public void South()
        {
            Assert.AreEqual(expected:new Vector3(x:0, y:-1, z:0), actual:south.GetVector());
        }

        public void West()
        {
            Assert.AreEqual(expected:new Vector3(x:-1, y:0, z:0), actual:west.GetVector());
        }

    }
}
