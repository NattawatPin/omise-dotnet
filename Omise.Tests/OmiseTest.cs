using System;
using NUnit.Framework;
using System.Net;

namespace Omise.Tests {
    [TestFixture]
    public abstract class OmiseTest {
        protected static readonly Credentials DummyCredentials = new Credentials("pkey_test_123", "skey_test_123");
    }
}


