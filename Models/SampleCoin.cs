using System.Diagnostics;

namespace Models
{
    /*
     *  Measurements of a sample coin.
     *  For now, we just measure weight in grams and diameter in millimeters.
     *  In the future, we may measure thickness, magnetism, color, and other measurements to avoid slugs.
     *  So we are future-proofing this (YAGNI!).  This way, we pass a SampleCoin, rather than list of measurements.
     *
     *  Also does tests on Sample Coin
     */
    public class SampleCoin
    {
        public float WeightGrams { get; private set; }
        public float DiameterMm { get; private set; }

        public SampleCoin(float weightGrams, float diameterMm)
        {
            Debug.Assert(weightGrams > 0, "weightGrams > 0");
            Debug.Assert(diameterMm > 0, "diameterMm > 0");

            WeightGrams = weightGrams;
            DiameterMm = diameterMm;
        }

        public bool IsValid
        {
            get
            {
                StandardCoinMetrics.ExamineCoin(this);

                return StandardCoinMetrics.IsValid;
            }
        }

        public int CoinValue
        {
            get
            {
                Debug.Assert(IsValid);

                return StandardCoinMetrics.MatchedValueCents;
            }
        }

        public string CoinName
        {
            get
            {
                Debug.Assert(IsValid);

                return StandardCoinMetrics.MatchedName;
            }
        }

    }
}
