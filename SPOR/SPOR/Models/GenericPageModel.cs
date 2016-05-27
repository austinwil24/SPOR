namespace SPOR.Models
{
    public class GenericPageModel
    {
        public GenericPageModel(string title)
        {
            Title = title;
        }

        public string Title { get; set; } = string.Empty;

        public string TitleExtension { get; set; } = string.Empty;
    }
}