
using Xunit;
namespace Deliverable1.Tests
{



    // Often it's good to take requirements and put them into tests.
    public class UnitTest1
    {

        private (int WholeLoafs, int RemainingSlices) CalculateNumberOfLoafs(int slices)
        {
            const int slicesPerLoaf = 28;
            var wholeLoafs = slices / slicesPerLoaf;
            var remainingSlices = slices % slicesPerLoaf;

            return (wholeLoafs, remainingSlices);
        }
        [Fact]
        public void Assert_CalculateNumberOfLoafs()
        {

            var slices = 400;
            var result = CalculateNumberOfLoafs(slices);

            Assert.Equal(14, result.WholeLoafs);
            Assert.Equal(8, result.RemainingSlices);
        }

        [Fact]
        public void Assert_CalculateNumberOfLoafs_LessThanOneLoaf()
        {

            var slices = 4;
            var result = CalculateNumberOfLoafs(slices);

            Assert.Equal(0, result.WholeLoafs);
            Assert.Equal(4, result.RemainingSlices);
        }

        [Fact]
        public void CheckForNulls()
        {
            string test = string.Empty;

            Assert.Equal("", test);


            string test2 = null;

            Assert.Equal(null, test2);


            if (string.IsNullOrEmpty("whatever string value"))
            {

            }

            if (test2 is null)
            {

            }
            var isIsNull = string.IsNullOrEmpty(null);

        }
    }
}