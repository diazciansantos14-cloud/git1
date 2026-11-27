namespace test1
{
    public static class UserSession
    {
        public static int UserID { get; set; } = 0;
        public static string Username { get; set; } = "Guest";
        public static string FullName { get; set; } = "Guest User";
        public static string Role { get; set; } = "Staff/Cashier"; // 'Admin', 'Staff/Cashier', 'Technician', 'Supplier'
        public static int? SupplierID { get; set; } = null;
        public static string SupplierName { get; set; } = null;

        public static bool IsAdmin => Role == "Admin";
        public static bool IsStaff => Role == "Staff/Cashier" || Role == "Admin";
        public static bool IsTechnician => Role == "Technician" || Role == "Admin";
        public static bool IsSupplier => Role == "Supplier";

        public static void Clear()
        {
            UserID = 0;
            Username = "Guest";
            FullName = "Guest User";
            Role = "Staff/Cashier";
            SupplierID = null;
            SupplierName = null;
        }
    }
}
