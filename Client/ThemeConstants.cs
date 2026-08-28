namespace Ncube.Theme.PlanetMinistries;

public static class ThemeConstants
{
    public const string ThemePackageName = "Ncube.Theme.PlanetMinistries";
    public const string AssetBasePath = $"~/Themes/{ThemePackageName}";

    public const string BrandLogoUrlSetting = "Brand_LogoUrl";
    public const string BrandHeaderStyleSetting = "Brand_HeaderStyle";
    public const string BrandFooterCopySetting = "Brand_FooterCopy";

    public static class Panes
    {
        public const string HeaderBillboard = "HeaderBillboard";
        public const string MainBody = "MainBody";
        public const string LeftSidebar = "LeftSidebar";
        public const string RightSidebar = "RightSidebar";
        public const string BottomFeature = "BottomFeature";
        public const string Default = $"{HeaderBillboard},{MainBody},{LeftSidebar},{RightSidebar},{BottomFeature}";
        public const string FullWidth = $"{HeaderBillboard},{MainBody},{BottomFeature}";
    }
}