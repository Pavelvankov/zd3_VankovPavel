using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace StoreTests
{
    [TestClass]
    public class StoreQualityTests
    {
        [TestMethod]
        public void Test1()
        {
            var store = new Store("Пятерочка", 100, 50000);
            var quality = store.Quality();
            Assert.AreEqual(500, quality);
        }

        [TestMethod]
        public void Test2()
        {
            var store = new Store("Магнит", 0, 50000);
            var quality = store.Quality();
            Assert.AreEqual(0, quality);
        }
    }

    [TestClass]
    public class ChainStoreQualityTests
    {
        [TestMethod]
        public void Test3()
        {
            var chainStore = new ChainStore("Ашан", 200, 100000, 60000, "Москва");
            var quality = chainStore.Quality();
            Assert.AreEqual(1000, quality);
        }

        [TestMethod]
        public void Test4()
        {
            var chainStore = new ChainStore("Перекресток", 200, 100000, 40000, "СанктПетербург");
            var quality = chainStore.Quality();
            Assert.AreEqual(250, quality);
        }

        [TestMethod]
        public void Test5()
        {
            var chainStore = new ChainStore("Лента", 200, 100000, 50000, "Казань");
            var quality = chainStore.Quality();
            Assert.AreEqual(250, quality);
        }
    }


}