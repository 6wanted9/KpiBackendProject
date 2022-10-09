namespace KpiBackendProject.Constants
{
    public static class Routes
    {
        public static class User
        {
            public const string Create = "create";
            public const string GetAll = "get-all";
        }

        public static class Category
        {
            public const string Create = "create";
            public const string GetAll = "get-all";
        }

        public static class Record
        {
            public const string Create = "create";
            public const string GetByUser = "get-by-user";
            public const string GetByUserAndCategory = "get-by-user-and-category";
        }
    }
}