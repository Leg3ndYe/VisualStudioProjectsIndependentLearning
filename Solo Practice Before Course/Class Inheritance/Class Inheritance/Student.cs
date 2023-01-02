namespace Class_Inheritance
{
    class Student : Human
    {
        public int StudentID { get; set; }
        public int Grade { get; set; }
        public string FavoriteSubject { get; set; }
        public Student(BaseHumanInfo baseHumanInfo, int studentID, int grade, string favoriteSubject) : base(baseHumanInfo)
        {
            StudentID = studentID;
            Grade = grade;
            FavoriteSubject = favoriteSubject;
        }
        public override string GetInfo()
        {
            string humanInfo = base.GetInfo();
            return humanInfo +
                $"\nStudentID: {StudentID}" +
                $"\nGrade: {Grade}" +
                $"\nFavoriteSubject: {FavoriteSubject}";
        }
    }
}
