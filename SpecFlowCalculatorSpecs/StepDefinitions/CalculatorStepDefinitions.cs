using SpecFlowCalculator;
using FluentAssertions;

namespace SpecFlowCalculatorSpecs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext _scenarioContext;

        private readonly Calculator _calculator = new Calculator();
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenariContext)
        {
            _scenarioContext = scenariContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.Subtract();
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiply();
        }

        [When(@"operation \+ is done to the number (.*)")]
        public void WhenPlusIsDoneToTheNumber(int number)
        {
            _calculator.SecondNumber = number;
            _result = _calculator.Add();
            _calculator.FirstNumber = _result;
        }

        [When(@"operation / is done to the number (.*)")]
        public void WhenDivideIsDoneToTheNumber(int number)
        {
            _calculator.SecondNumber = number;
            _result = _calculator.Divide();
            _calculator.FirstNumber = _result;
        }

        [When(@"operation - is done to the number (.*)")]
        public void WhenMinusIsDoneToTheNumber(int number)
        {
            _calculator.SecondNumber = number;
            _result = _calculator.Subtract();
            _calculator.FirstNumber = _result;
        }

        [When(@"operation % is done to the number (.*)")]
        public void WhenModuloIsDoneToTheNumber(int number)
        {
            _calculator.SecondNumber = number;
            _result = _calculator.Modulo();
            _calculator.FirstNumber = _result;
        }
    }
}