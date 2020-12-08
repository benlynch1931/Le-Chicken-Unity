using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        
        [UnityTest]
        public IEnumerator MoveRight()
        {
            var gameObject = new GameObject();
            var chicken = GameObject.AddComponent<PlayerController>();
            chicken.Move(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f))
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
