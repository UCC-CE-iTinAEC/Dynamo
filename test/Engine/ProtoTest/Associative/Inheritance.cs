using System;
using NUnit.Framework;
using ProtoCore.DSASM.Mirror;
using ProtoTest.TD;
using ProtoTestFx.TD;
namespace ProtoTest.Associative
{
    class InheritaceTest : ProtoTestBase
    {
        [Test]
        public void InheritanceTest01()
        {
            String code =
@"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Assert.IsTrue((double)mirror.GetValue("rbVelocity").Payload == 19.6);
            Assert.IsTrue((double)mirror.GetValue("lt").Payload == 0.25);
            Assert.IsTrue((double)mirror.GetValue("particleVelocity").Payload == 39.2);
        }

        [Test]
        public void InheritanceTest02()
        {
            String code =
@"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Assert.IsTrue((Int64)mirror.GetValue("i").Payload == 1);
        }

        [Test]
        public void InheritanceTest03()
        {
            String code =
@"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Assert.IsTrue((double)mirror.GetValue("x", 0).Payload == 100);
        }

        [Test]
        public void InheritanceTest04()
        {
            String code =
@"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Assert.IsTrue((double)mirror.GetValue("x", 0).Payload == 10);
        }


        [Test]
        public void InheritanceTest05()
        {
            String code =
@"
            ExecutionMirror mirror = thisTest.RunScriptSource(code);
            Assert.IsTrue((bool)mirror.GetValue("xn").Payload);
            Assert.IsTrue((Int64)mirror.GetValue("xo").Payload == 2);

        }
    }
}