using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace StudentForm
{
    public partial class StudentForm : Form
    {
        List<Student> students = new List<Student>();
        public StudentForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StudentCount.Text = string.Format("จำนวนนักศึกษา {0} คน", students.Count().ToString());
            MaxGrade.Text = "เกรดสูงสุดคือ 0";
            MinGrade.Text = "เกรดต่ำสุดคือ 0";
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            List<double> sortgrade = new List<double>();
            string Name, ID, Major;
            double Height, Grade;
            int Year;
            try
            {
                Name = TextBox_Name.Text;
                ID = TextBox_ID.Text;
                Year = int.Parse(TextBox_Year.Text);
                Height = int.Parse(TextBox_Tall.Text);
                Grade = double.Parse(TextBox_Grade.Text);
                Major = TextBox_Major.Text;
            }
            catch (Exception ex)
            {
                string newex = ex.ToString();
                List<string> arrexception = new();
                if(newex.Contains("line 30"))
                {
                    arrexception.Add("ปีเกิด");
                }
                if (newex.Contains("line 31"))
                {
                    arrexception.Add("ความสูง");
                }
                if (newex.Contains("line 32"))
                {
                    arrexception.Add("เกรด");
                }
                MessageBox.Show(caption: "Error", text: string.Format("กรุณาตรวจสอบ {0}", arrexception.ToArray()), icon: MessageBoxIcon.Error, buttons: MessageBoxButtons.OK);
                return;
            }
            Name = TextBox_Name.Text; ID = TextBox_ID.Text; Year = int.Parse(TextBox_Year.Text); Height = int.Parse(TextBox_Tall.Text); Grade = double.Parse(TextBox_Grade.Text); Major = TextBox_Major.Text;
            Student student = new Student();
            student.SetData(EStudentType._Name, Name).SetData(EStudentType._Id, ID).SetData(EStudentType._BirthYear, Year).SetData(EStudentType._Height, Height).SetData(EStudentType._Grade, Grade).SetData(EStudentType._Marjor, Major);
            students.Add(student);
            TableDataGrid.Rows.Clear();
            foreach(Student std in students)
            {
                sortgrade.Add(double.Parse(std.GetData(EStudentType._Grade).ToString()));
                TableDataGrid.Rows.Add(
                    std.GetData(EStudentType._Name),
                    std.GetData(EStudentType._Id),
                    std.GetData(EStudentType._BirthYear),
                    std.GetData(EStudentType._Height),
                    std.GetData(EStudentType._Grade),
                    std.GetData(EStudentType._Marjor)
                );
            }
            sortgrade.Sort();
            MaxGrade.Text = string.Format("เกรดสูงสุดคือ {0}", sortgrade.Last().ToString());
            MinGrade.Text = string.Format("เกรดต่ำสุดคือ {0}", sortgrade.First().ToString());
            this.StudentCount.Text = string.Format("จำนวนนักศึกษา {0} คน", students.Count().ToString());
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            TextBox_Name.Text = "";
            TextBox_ID.Text = "";
            TextBox_Year.Text = "";
            TextBox_Tall.Text = "";
            TextBox_Grade.Text = "";
            TextBox_Major.Text = "";
        }

        private void ShowDataInGrid_btn_Click(object sender, EventArgs e)
        {
            students.Clear();
            TableDataGrid.Rows.Clear();
            StudentCount.Text = "จำนวนนักศึกษา 0 คน";
            MaxGrade.Text = "เกรดสูงสุดคือ 0";
            MinGrade.Text = "เกรดต่ำสุดคือ 0";
        }
    }

}