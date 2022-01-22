using NUnit.Framework;
using static Playground.Utils.DriverFactory;

namespace Playground.Core
{
    public class Base
    {
        [TearDown]
        public void TearDown()
        {
            KillDriver();
        }
    }
}
