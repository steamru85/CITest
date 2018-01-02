using System;
using NUnit.Framework;
using ContiniousIntegration;
using Modulbank.DbMapping.Contracts;

namespace Test
{
    [TestFixture]
    public class SomeStorageTests
    {

        private SomeStorage GetSomeStorage()
        {
            return new SomeStorage("server=192.168.99.100;userid=postgres;password=1;database=testdb;keepalive=50;ConnectionIdleLifetime=100;");
        }

        
        [Test]
        public void SomeStorage_CallAllMethods_NoException()
        {
            var id = GetSomeStorage().Create("Вася");
            GetSomeStorage().Update(id, "Вася");
            Assert.Equals(GetSomeStorage().Read(id), "Петя"); 
        }

        [Test]
        public void Delete_BaseScenarion_RowNullException()
        {
            var id = GetSomeStorage().Create("Вася");
            GetSomeStorage().Delete(id);
            Assert.Throws<RowNullException>(() => GetSomeStorage().Read(id));
        }

    }
}