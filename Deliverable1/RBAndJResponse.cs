public class RBAndJResponse
{
    public int NumberOfPeople { get; set; }
    public int SlicesOfBreadRequired { get; set; }
    public int PeanutButterTbsp { get; set; }
    public int JellyTsps { get; set; }


    public int LoafsRequired { get; set; }
    public int PeanutButterJarsRequired { get; set; }
    public int JellyJarsRequired { get; set; }

    public override string ToString()
    {
        var Padding = "    ";

        return 
            $@"To Serve {NumberOfPeople}, You Will Need: 
    {SlicesOfBreadRequired} Slices Of Bread 
    {PeanutButterTbsp} Tablespoons Of PeanutButter 
    {JellyTsps} Teaspoons Of Jelly 
Which Is: 
    {LoafsRequired} Loafs Of Bread 
    {PeanutButterJarsRequired} Jars Of Peanut Butter 
    {JellyJarsRequired} Jars Of Jelly 
";
    }
}