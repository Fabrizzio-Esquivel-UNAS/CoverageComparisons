using TestClasses;

namespace TestProject1
{
    [TestClass]
    public class TestMethods
    {
        /*
         * To achieve decision coverage, we need to ensure that each conditional branch (if statement) is evaluated to both true and false at least once. 
         */
        [TestMethod]
        public void TestCalculateShippingCost_DecisionCoverage()
        {
            var processor = new LogisticsProcessor();

            // Decision Coverage Test Cases

            // Case 1: Non-fragile, non-expedited, weight <= 50, distance <= 1000
            double result1 = processor.CalculateShippingCost(10, 500, false, false);
            Assert.AreEqual(126, result1); // (10 * 0.5 + 500 * 0.2 + 3 * 2.0)

            // Case 2: Fragile, non-expedited, weight <= 50, distance <= 1000
            double result2 = processor.CalculateShippingCost(10, 500, true, false);
            Assert.AreEqual(131, result2); // (10 * 0.5 + 500 * 0.2 + 3 * 2.0 + 5)

            // Case 3: Non-fragile, expedited, weight <= 50, distance <= 1000
            double result3 = processor.CalculateShippingCost(10, 500, false, true);
            Assert.AreEqual(189, result3); // ((10 * 0.5 + 500 * 0.2 + 3 * 2.0) * 1.5)

            // Case 4: Non-fragile, non-expedited, weight > 50, distance <= 1000
            double result4 = processor.CalculateShippingCost(60, 500, false, false);
            Assert.AreEqual(156, result4); // (60 * 0.5 + 500 * 0.2 + 3 * 2.0 + 10)

            // Case 5: Non-fragile, non-expedited, weight <= 50, distance > 1000
            double result5 = processor.CalculateShippingCost(10, 1500, false, false);
            Assert.AreEqual(364, result5); // ((10 * 0.5 + 1500 * 0.2 + 3 * 2.0) * 1.1)

            // Case 6: Fragile, expedited, weight <= 50, distance > 1000
            double result6 = processor.CalculateShippingCost(10, 1500, true, true);
            Assert.AreEqual(671.0, result6); // (((10 * 0.5 + 1500 * 0.2 + 3 * 2.0 + 5) * 1.1) * 1.5)

            // Case 7: Fragile, expedited, weight > 50, distance <= 1000
            double result7 = processor.CalculateShippingCost(60, 500, true, true);
            Assert.AreEqual(291, result7); // ((60 * 0.5 + 500 * 0.2 + 3 * 2.0 + 5 + 10) * 1.5)

            // Case 8: Fragile, non-expedited, weight > 50, distance > 1000
            double result8 = processor.CalculateShippingCost(60, 1500, true, false);
            Assert.AreEqual(473, result8); // ((60 * 0.5 + 1500 * 0.2 + 3 * 2.0 + 5 + 10) * 1.1)
        }

        /*
         * To achieve branch coverage, we need to ensure that every possible branch in the code is executed at least once.
         */
        [TestMethod]
        public void TestCalculateShippingCost_BranchCoverage()
        {
            var processor = new LogisticsProcessor();

            // Branch Coverage Test Cases

            // Case 1: Non-fragile, non-expedited, weight <= 50, distance <= 1000
            double result1 = processor.CalculateShippingCost(10, 500, false, false);
            Assert.AreEqual(126, result1); // (10 * 0.5 + 500 * 0.2 + 3 * 2.0)

            // Case 2: Fragile, non-expedited, weight <= 50, distance <= 1000
            double result2 = processor.CalculateShippingCost(10, 500, true, false);
            Assert.AreEqual(131, result2); // (10 * 0.5 + 500 * 0.2 + 3 * 2.0 + 5)

            // Case 3: Non-fragile, expedited, weight <= 50, distance <= 1000
            double result3 = processor.CalculateShippingCost(10, 500, false, true);
            Assert.AreEqual(189, result3); // ((10 * 0.5 + 500 * 0.2 + 3 * 2.0) * 1.5)

            // Case 4: Non-fragile, non-expedited, weight > 50, distance <= 1000
            double result4 = processor.CalculateShippingCost(60, 500, false, false);
            Assert.AreEqual(156, result4); // (60 * 0.5 + 500 * 0.2 + 3 * 2.0 + 10)

            // Case 5: Non-fragile, non-expedited, weight <= 50, distance > 1000
            double result5 = processor.CalculateShippingCost(10, 1500, false, false);
            Assert.AreEqual(364, result5); // ((10 * 0.5 + 1500 * 0.2 + 3 * 2.0) * 1.1)
        }

        /*
         * Data flow coverage ensures that each definition-use pair in the code is covered by a test case.
         */
        [TestMethod]
        public void TestCalculateShippingCost_DataFlowCoverage()
        {
            var processor = new LogisticsProcessor();

            // Data Flow Coverage Test Cases

            // Case 1: Non-fragile, non-expedited, weight <= 50, distance <= 1000
            double result1 = processor.CalculateShippingCost(10, 500, false, false);
            Assert.AreEqual(126, result1); // (10 * 0.5 + 500 * 0.2 + 3 * 2.0)

            // Case 2: Non-fragile, non-expedited, weight <= 50, distance > 1000
            double result2 = processor.CalculateShippingCost(10, 1500, false, false);
            Assert.AreEqual(364, result2); // ((10 * 0.5 + 1500 * 0.2 + 3 * 2.0) * 1.1)

            // Case 3: Fragile, non-expedited, weight > 50, distance <= 1000
            double result3 = processor.CalculateShippingCost(60, 500, true, false);
            Assert.AreEqual(291, result3); // ((60 * 0.5 + 500 * 0.2 + 3 * 2.0 + 5 + 10) * 1.5)

            // Case 4: Fragile, non-expedited, weight > 50, distance > 1000
            double result4 = processor.CalculateShippingCost(60, 1500, true, false);
            Assert.AreEqual(473, result4); // ((60 * 0.5 + 1500 * 0.2 + 3 * 2.0 + 5 + 10) * 1.1)

            // Case 5: Non-fragile, expedited, weight <= 50, distance <= 1000
            double result5 = processor.CalculateShippingCost(10, 500, false, true);
            Assert.AreEqual(189, result5); // ((10 * 0.5 + 500 * 0.2 + 3 * 2.0) * 1.5)

            // Case 6: Fragile, expedited, weight <= 50, distance <= 1000
            double result6 = processor.CalculateShippingCost(10, 500, true, true);
            Assert.AreEqual(274.5, result6); // (((10 * 0.5 + 500 * 0.2 + 3 * 2.0 + 5) * 1.5) * 1.1)

            // Case 7: Non-fragile, non-expedited, weight > 50, distance <= 1000
            double result7 = processor.CalculateShippingCost(60, 500, false, false);
            Assert.AreEqual(156, result7); // ((60 * 0.5 + 500 * 0.2 + 3 * 2.0 + 10))

            // Case 8: Non-fragile, expedited, weight <= 50, distance > 1000
            double result8 = processor.CalculateShippingCost(10, 1500, false, true);
            Assert.AreEqual(400.4, result8); // (((10 * 0.5 + 1500 * 0.2 + 3 * 2.0) * 1.1) * 1.5)
        }
    }
}