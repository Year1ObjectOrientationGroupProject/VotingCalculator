public class Country {
    private string name;
    private float percentageOfPopulation;

    public Country(string inpName, float inpPercentageOfPopulation) {
        name = inpName;
        percentageOfPopulation = inpPercentageOfPopulation;
    }

    public string getName() {
        return name;
    }

    public float getPercentageOfPop() {
        return percentageOfPopulation;
    }
}