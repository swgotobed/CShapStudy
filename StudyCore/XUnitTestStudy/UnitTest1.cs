using Moq;
using StudyCore.Study;
using System.Collections.Generic;
using Xunit;
namespace XUnitTestStudy
{
    public class UnitTest1
    {
        [Theory]
        [MemberData(nameof(InternalHealthDamageTestData.TestData), MemberType = typeof(InternalHealthDamageTestData))]
        public void Test1(int a, int b)
        {
            var mockIwt = new Mock<ITestWebservice>();
            mockIwt.Setup(p => p.test(It.Is<int>(intVal => intVal != 0)))
                .Returns(1);

            StudyCShapFirst st = new StudyCShapFirst(mockIwt.Object);
            Assert.Equal(1, st.Add(1, 0));
            Assert.Equal(2, st.Add(0, 2));
            Assert.Equal(3, st.Add(5, 2));
        }
    }

    public class InternalHealthDamageTestData
    {
        private static readonly List<object[]> Data = new List<object[]>
        {
            new object[] {0, 100},
            new object[] {1, 99},
            new object[] {50, 50},
            new object[] {101, 1}
        };

        public static IEnumerable<object[]> TestData => Data;
    }
}
