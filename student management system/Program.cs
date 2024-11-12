namespace student_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UndergraduateStudent undergraduate = new UndergraduateStudent("Harishanth" , 24 ,"E020549", "BEng(Hons)" , 2024);

            GraduateStudent graduate = new GraduateStudent("Harishanth", 24, "E020549", "Application Development", "Mr.Chamila");

            undergraduate.DisplayDetails();

            undergraduate.DisplayBasicInfo();

            graduate.DisplayBasicInfo();

            graduate.DisplayDetails();
        }
    }
}
