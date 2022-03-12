namespace AhoyHotelApi
{
    public static class ApiRoute
    {
        public static class ApplicatonUserRoutes
        {
            public const string Register = "register";
            public const string Login = "login";
        }
        public static class BookingRoutes
        {
            public const string AddBooking = "add";
        }
        public static class HotelRoutes
        {
            public const string GetAllHotels = "getAllHotels";
            public const string GetHotelDetailsById = "getHotelDetalsById";
            public const string SearchInHotels = "searchByTerm";
        }
    }
}
