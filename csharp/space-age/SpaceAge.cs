using System;

public class SpaceAge
{
    #region Constants

    private const double SecondsInEarthYear = 31557600;
    private const double MercuryToEarthYears = 0.2408467;
    private const double VenusToEarthYears = 0.61519726;
    private const double MarsToEarthYears = 1.8808158;
    private const double JupiterToEarthYears = 11.862615;
    private const double SaturnToEarthYears = 29.447498;
    private const double UranusToEarthYears = 84.016846;
    private const double NeptuneToEarthYears = 164.79132;

    #endregion Constants

    public double Seconds { get; private set; }

    public SpaceAge(int seconds)
    {
        this.Seconds = seconds;
    }

    public double EarthYearsToPlanetYears(double planetToEarthYears = 1.0){
        return Math.Round(Seconds / SecondsInEarthYear / planetToEarthYears, 2);
    }

    public double OnEarth()
    {
        return EarthYearsToPlanetYears();
    }

    public double OnMercury()
    {
        return EarthYearsToPlanetYears(MercuryToEarthYears);
    }

    public double OnVenus()
    {
        return EarthYearsToPlanetYears(VenusToEarthYears);
    }

    public double OnMars()
    {
        return EarthYearsToPlanetYears(MarsToEarthYears);
    }

    public double OnJupiter()
    {
        return EarthYearsToPlanetYears(JupiterToEarthYears);
    }

    public double OnSaturn()
    {
        return EarthYearsToPlanetYears(SaturnToEarthYears);
    }

    public double OnUranus()
    {
        return EarthYearsToPlanetYears(UranusToEarthYears);
    }

    public double OnNeptune()
    {
        return EarthYearsToPlanetYears(NeptuneToEarthYears);
    }
}