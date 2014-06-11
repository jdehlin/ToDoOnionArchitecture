namespace ToDoApp.Website
{
    public class AutoMapperConfig
    {
        public static void CreateMappings()
        {
            Domain.Mappings.Initialize();
        }
    }
}