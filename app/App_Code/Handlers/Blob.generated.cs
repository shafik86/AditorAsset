namespace MyCompany.Handlers
{


    public partial class BlobFactoryConfig : BlobFactory
    {

        public static void Initialize()
        {
            // register blob handlers
            RegisterHandler("AuditorImage", "\"dbo\".\"Auditor\"", "\"Image\"", new string[] {
                        "\"AuditorId\""}, "Auditor Image", "Auditor", "Image");
            RegisterHandler("DefectDescriptionImage1", "\"dbo\".\"DefectDescription\"", "\"image1\"", new string[] {
                        "\"DefectDescriptionID\""}, "Defect Description Image 1", "DefectDescription", "Image1");
            RegisterHandler("DefectDescriptionImage2", "\"dbo\".\"DefectDescription\"", "\"image2\"", new string[] {
                        "\"DefectDescriptionID\""}, "Defect Description Image 2", "DefectDescription", "Image2");
            RegisterHandler("DefectDescriptionImage3", "\"dbo\".\"DefectDescription\"", "\"image3\"", new string[] {
                        "\"DefectDescriptionID\""}, "Defect Description Image 3", "DefectDescription", "Image3");
            RegisterHandler("DefectDescriptionImage1After", "\"dbo\".\"DefectDescription\"", "\"image1After\"", new string[] {
                        "\"DefectDescriptionID\""}, "Defect Description Image 1 After", "DefectDescription", "Image1After");
            RegisterHandler("DefectDescriptionImage2After", "\"dbo\".\"DefectDescription\"", "\"image2After\"", new string[] {
                        "\"DefectDescriptionID\""}, "Defect Description Image 2 After", "DefectDescription", "Image2After");
            RegisterHandler("DefectDescriptionImage3After", "\"dbo\".\"DefectDescription\"", "\"image3After\"", new string[] {
                        "\"DefectDescriptionID\""}, "Defect Description Image 3 After", "DefectDescription", "Image3After");
            RegisterHandler("ImageImage", "\"dbo\".\"Image\"", "\"Image\"", new string[] {
                        "\"ImageId\""}, "Image Image", "Image", "Image");
        }
    }
}
