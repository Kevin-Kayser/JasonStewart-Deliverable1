public class PBandJService
{
    private readonly int _numberOfPeople;
    private readonly int _breadSlicesPerLoaf;
    private readonly int _peanutButterTablespoonsPerJar;
    private readonly int _jellyTeaspoonsPerJar;


    public PBandJService(int numberOfPeople)
    {
        _numberOfPeople = numberOfPeople;
        _breadSlicesPerLoaf = 28;
        _peanutButterTablespoonsPerJar = 32;
        _jellyTeaspoonsPerJar = 48;
    }


    private (int WholeLoafs, int RemainingSlices) CalculateNumberOfLoafs(int slices)
    {
        var wholeLoafs = slices / _breadSlicesPerLoaf;
        var remainingSlices = slices % _breadSlicesPerLoaf;

        return (wholeLoafs, remainingSlices);
    }

    private int BreadSlicesRequired => _numberOfPeople * 2;
    public int GetLoafsRequired()
    {
        return (int)Math.Ceiling((decimal)((BreadSlicesRequired * 1.0) / _breadSlicesPerLoaf));
    }

    private int PeanutButterTablespoonsRequired => _numberOfPeople * 2;
    public int GetPeanutButterJarsRequired()
    {
        return (int)Math.Ceiling((decimal)((PeanutButterTablespoonsRequired * 1.0) / _peanutButterTablespoonsPerJar));
    }
    private int JellyTeaspoonsRequired => _numberOfPeople * 4;
    public int GetJellyJarsRequired()
    {
        return (int)Math.Ceiling((decimal)((JellyTeaspoonsRequired * 1.0) / _jellyTeaspoonsPerJar));
    }

    public RBAndJResponse GetResults()
    {
        return new RBAndJResponse()
        {
            NumberOfPeople = _numberOfPeople,
            JellyJarsRequired = GetJellyJarsRequired(),
            JellyTsps = JellyTeaspoonsRequired,
            SlicesOfBreadRequired = BreadSlicesRequired,
            LoafsRequired = GetLoafsRequired(),
            PeanutButterJarsRequired = GetPeanutButterJarsRequired(),
            PeanutButterTbsp = PeanutButterTablespoonsRequired,
        };
    }

}