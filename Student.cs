namespace StudentForm
{
    public class Student
    {
        private string? _Name;
        private string? _Id;
        private int? _BirthYear;
        private double? _Height;
        private double? _Grade;
        private string? _Marjor;

        public Student SetData(EStudentType type, object? data)
        {
            switch (type)
            {
                case EStudentType._Name:
                    _Name = data.ToString();
                    break;
                case EStudentType._Id:
                    _Id = data.ToString();
                    break;
                case EStudentType._BirthYear:
                    _BirthYear = int.Parse(data.ToString());
                    break;
                case EStudentType._Height:
                    _Height = double.Parse(data.ToString());
                    break;
                case EStudentType._Grade:
                    _Grade = double.Parse(data.ToString());
                    break;
                case EStudentType._Marjor:
                    _Marjor = data.ToString();
                    break;
            }
            return this;
        }
        public object GetData(EStudentType type)
        {
            object? Data = null;
            switch (type)
            {
                case EStudentType._Name:
                    Data = _Name;
                    break;
                case EStudentType._Id:
                    Data = _Id;
                    break;
                case EStudentType._BirthYear:
                    Data = _BirthYear;
                    break;
                case EStudentType._Height:
                    Data = _Height;
                    break;
                case EStudentType._Grade:
                    Data = _Grade;
                    break;
                case EStudentType._Marjor:
                    Data = _Marjor;
                    break;
            }
            return Data;
        }
    }
    public enum EStudentType {
        _Name = 0,
        _Id = 1,
        _BirthYear = 2,
        _Height = 3,
        _Grade = 4,
        _Marjor = 5
    };
}
