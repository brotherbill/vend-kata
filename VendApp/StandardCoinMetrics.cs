using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace VendApp
{
  /*
   *  This class defines whether a coin is valid or not, and its associated coin value.
      We add the name for sanity.
      An invalid coin has value of 0.00.

      We apply the unit to ensure reader knows the unit.  See failing NASA Mars mission.
      We use float, but could use double or decimal.  float is good for low precision sensors.
   */
  public class StandardCoinMetrics
  {
    public string Name { get; }
    public int ValueCents { get; }
    public float MinWeightGrams { get; }
    public float MaxWeightGrams { get; }
    public float MinDiameterMm { get; }
    public float MaxDiameterMm { get; }

    private static int _matchedIndex;
    public static bool IsValid => _matchedIndex >= 0;

    public static string MatchedName
    {
      get
      {
        Debug.Assert(_matchedIndex >= 0);

        return _allCoinMetrics[_matchedIndex].Name;
      }
    }

    public static int MatchedValueCents
    {
      get
      {
        Debug.Assert(_matchedIndex >= 0);

        return _allCoinMetrics[_matchedIndex].ValueCents;
      }
    }

    private static StandardCoinMetrics[] _allCoinMetrics;

    // Static Constructor
    static StandardCoinMetrics()
    {
      _allCoinMetrics = new StandardCoinMetrics[3];

      _allCoinMetrics[0] = new StandardCoinMetrics(
        name: "Nickel",
        valueCents: 5,
        minWeightGrams: 4.990f,
        maxWeightGrams: 5.020f,
        minDiameterMm: 21.10f,
        maxDiameterMm: 21.30f);

      _allCoinMetrics[1] = new StandardCoinMetrics(
        name: "Dime",
        valueCents: 10,
        minWeightGrams: 2.250f,
        maxWeightGrams: 2.280f,
        minDiameterMm: 17.70f,
        maxDiameterMm: 18.00f);

      _allCoinMetrics[2] = new StandardCoinMetrics(
        name: "Quarter",
        valueCents: 25,
        minWeightGrams: 5.660f,
        maxWeightGrams: 5.680f,
        minDiameterMm: 24.10f,
        maxDiameterMm: 25.40f);
    }

    // Object Constructor
    public StandardCoinMetrics(string name, int valueCents,
      float minWeightGrams, float maxWeightGrams,
      float minDiameterMm, float maxDiameterMm)
    {
      Debug.Assert(!string.IsNullOrWhiteSpace(name), "Not null and not all white space");
      Debug.Assert(name == name.Trim(), "name must be Trimmed");

      Debug.Assert(0 < valueCents && valueCents <= 100, "valueCents must be at least 1 cent and no more than a dollar");

      Debug.Assert(1.0f <= minWeightGrams && minWeightGrams <= 10.0, "minWeightGrams must be between 1.0g and 10g");
      Debug.Assert(1.2f <= maxWeightGrams && maxWeightGrams <= 12.0, "maxWeightGrams must be between 1.2g and 12g");
      Debug.Assert(minWeightGrams < maxWeightGrams, "minWeightGrams must be less than maxWeightGrams");

      Debug.Assert(10.0f <= minDiameterMm && minDiameterMm <= 100.0, "minDiameterMm must be between 10.0mm and 100mm");
      Debug.Assert(12.0f <= maxDiameterMm && maxDiameterMm <= 102.0, "maxDiameterMm must be between 12.0mm and 102mm");
      Debug.Assert(minDiameterMm < maxDiameterMm, "minDiameterMm must be less than maxDiameterMm");

      Name = name;
      ValueCents = valueCents;
      MinWeightGrams = minWeightGrams;
      MaxWeightGrams = maxWeightGrams;
      MinDiameterMm = minDiameterMm;
      MaxDiameterMm = maxDiameterMm;

      _matchedIndex = -1;
    }

    /// <summary>
    /// Examines coin. If IsValid, then read MatchedName and MatchedValueCents
    /// </summary>
    /// <param name="coin">Sample coin</param>
    public static void ExamineCoin(SampleCoin coin)
    {
      Debug.Assert(coin != null, "coin may not be null");

      // Sets _matchedIndex
      _matchedIndex = -1;

      for (_matchedIndex = _allCoinMetrics.Length - 1; _matchedIndex >= 0; _matchedIndex--)
      {
        var item = _allCoinMetrics[_matchedIndex];

        if (IsValidCoin(coin, item))
          break;
      }
    }

    /// <summary>
    /// Coin is valid if in range of weight and diameter
    /// </summary>
    /// <param name="coin"></param>
    /// <param name="standardCoinMetrics"></param>
    /// <returns></returns>
    private static bool IsValidCoin(SampleCoin coin, StandardCoinMetrics standardCoinMetrics)
    {
      Debug.Assert(coin != null, "coin != null");
      Debug.Assert(standardCoinMetrics != null);

      var actWeight = coin.WeightGrams;
      var actDiameter = coin.DiameterMm;
      var minWeight = standardCoinMetrics.MinWeightGrams;
      var maxWeight = standardCoinMetrics.MaxWeightGrams;
      var minDiameter = standardCoinMetrics.MinDiameterMm;
      var maxDiameter = standardCoinMetrics.MaxDiameterMm;

      bool weightOk = (minWeight <= actWeight && actWeight <= maxWeight);
      bool diameterOk = (minDiameter <= actDiameter && actDiameter <= maxDiameter);
      return weightOk && diameterOk;
    }
  }
}